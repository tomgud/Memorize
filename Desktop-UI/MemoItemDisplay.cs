using System;
using Memorize;
using Memorize.Items;
using Gtk;
using Gdk;

namespace Memorize.DesktopUI
{
    public class MemoItemDisplay 
    {
        private Memo _item;
		private HBox _parent;
		private VBox _container;
		private Alignment _titleAlignment;
		private Alignment _contentAlignment;
		private Label _titleLabel;
		private TextView _titleTextView;
		private Label _contentLabel;
		private TextView _contentTextView;
		private EventBox _titleLabelListener;
		private EventBox _contentLabelListener;

        public Memo Item
        {
            get
            {
                return _item;
            }
        }

        public MemoItemDisplay(Memo m, HBox parent)
        {
            this._item = m;
			this._parent = parent;
			this._container = new VBox (false, 5);
			this._parent.Add(this._container); 
			this.Construct();
        }

		private void Construct()
		{
			// Title label
			_titleLabel = new Label ();
			_titleLabel.Text = this._item.GetTitle ();
			_titleLabel.SetAlignment (0, 0);
			// Label listener
			_titleLabelListener = new EventBox ();
			_titleLabelListener.ButtonPressEvent += new ButtonPressEventHandler (MemoTitlePressHandler);
			_titleLabelListener.Add (_titleLabel);
			// Title alignment
			_titleAlignment = new Alignment (0, 0, 0, 0);
			_titleAlignment.SetSizeRequest (80, 25);
			_titleAlignment.Add (_titleLabelListener);
			_titleAlignment.ShowAll ();
			// Content label
			_contentLabel = new Label ();
			_contentLabel.Text = this._item.GetContent ();
			_contentLabel.SetSizeRequest (200, 140);
			_contentLabel.SetAlignment (0, 0);
			_contentLabel.LineWrap = true;
			_contentLabel.Justify = Justification.Fill;
			// Label listener
			_contentLabelListener = new EventBox ();
			_contentLabelListener.ButtonPressEvent += new ButtonPressEventHandler (MemoContentPressHandler);
			_contentLabelListener.Add (_contentLabel);
			// Content aligment
			_contentAlignment = new Alignment (0, 0, 0, 1);
			_contentAlignment.Add (_contentLabelListener);
		}

        public void Display ()
		{
            // PackStart (child, expand, fill, padding)
            this._container.PackStart(_titleAlignment, false, false, 4);
            this._container.PackStart(_contentAlignment, false, false, 4);
            this._container.SetSizeRequest(220, 200);
			this._container.ShowAll();

            
        }

		public void SwitchContentView (bool edit)
		{
			if (edit) {	
				// Removing the label
				_contentLabelListener.Destroy();
				//_contentAlignment.Remove(_contentLabelListener);
				// Setting up the textview
				_contentTextView = new TextView ();
				_contentTextView.FocusInEvent += new FocusInEventHandler(MemoTextViewGotFocus);
				_contentTextView.FocusOutEvent += new FocusOutEventHandler(MemoContentTextViewLostFocus);
				TextBuffer contentBuffer = _contentTextView.Buffer;
				contentBuffer.Text = this._item.GetContent();
				_contentTextView.SetSizeRequest (200, 140);
				_contentTextView.Justification = Justification.Fill;
				_contentTextView.WrapMode = WrapMode.Word;
				_contentAlignment.Add (_contentTextView);
				_contentTextView.GrabFocus();
			} else {
				// Saving information from textview and removing it
				this._item.SetContent(_contentTextView.Buffer.Text);
				Console.WriteLine ("Setting memo content to " + _contentTextView.Buffer.Text);
				_contentTextView.Destroy();
				// Creating label
				_contentLabel = new Label();
				_contentLabel.Text = this._item.GetContent ();
				_contentLabel.SetSizeRequest (200, 140);
				_contentLabel.SetAlignment (0, 0);
				_contentLabel.LineWrap = true;
				_contentLabel.Justify = Justification.Fill;
				// Label listener
				_contentLabelListener = new EventBox ();
				_contentLabelListener.ButtonPressEvent += new ButtonPressEventHandler (MemoContentPressHandler);
				_contentLabelListener.Add (_contentLabel);
				_contentAlignment.Add (_contentLabelListener);
			}
			this._container.ShowAll();
		}
		/// <summary>
		/// See SwitchContentView.
		/// This is an awkward solution and should be refactored.
		/// The only other way I can think if is creating two different
		/// EventHandlers, and they call with different parameters which
		/// Label and TextView to switch (Content or Title).
		/// </summary>
		/// <param name='edit'>
		/// If true, paint a TextView that can be edited.
		/// If false, paint a Label that displays memo.
		/// </param>
		public void SwitchTitleView (bool edit)
		{
			if (edit) {	
				// Removing the label
				_titleLabelListener.Destroy();
				// Setting up the textview
				_titleTextView = new TextView ();
				_titleTextView.FocusInEvent += new FocusInEventHandler(MemoTextViewGotFocus);
				_titleTextView.FocusOutEvent += new FocusOutEventHandler(MemoTitleTextViewLostFocus);
				TextBuffer contentBuffer = _titleTextView.Buffer;
				contentBuffer.Text = this._item.GetTitle();
				_titleTextView.SetSizeRequest (200, 140);
				_titleTextView.Justification = Justification.Fill;
				_titleTextView.WrapMode = WrapMode.Word;
				_titleAlignment.Add (_titleTextView);
				_titleTextView.GrabFocus();
			} else {
				// Saving information from textview and removing it
				this._item.SetTitle(_titleTextView.Buffer.Text);
				Console.WriteLine ("Setting memo title to " + _contentTextView.Buffer.Text);
				_titleTextView.Destroy();
				// Creating label
				_titleLabel = new Label();
				_titleLabel.Text = this._item.GetTitle ();
				_titleLabel.SetSizeRequest (200, 140);
				_titleLabel.SetAlignment (0, 0);
				_titleLabel.LineWrap = true;
				_titleLabel.Justify = Justification.Fill;
				// Label listener
				_titleLabelListener = new EventBox ();
				_titleLabelListener.ButtonPressEvent += new ButtonPressEventHandler (MemoTitlePressHandler);
				_titleLabelListener.Add (_titleLabel);
				_titleAlignment.Add (_titleLabelListener);
			}
			this._container.ShowAll();
		}

		public void GenericTextViewHandler (object obj, EventArgs args)
		{
		}

		public void MemoTextViewGotFocus (object obj, FocusInEventArgs args)
		{
		}

		public void MemoTitleTextViewLostFocus (object obj, FocusOutEventArgs args)
		{
			// Textview lost focus, show label
			this.SwitchTitleView(false);
		}

		public void MemoContentTextViewLostFocus (object obj, FocusOutEventArgs args)
		{
			// Textview lost focus, show label
			this.SwitchContentView(false);
		}

		public void MemoTitlePressHandler (object obj, ButtonPressEventArgs args)
		{
			if (args.Event.Type == EventType.ButtonPress) {
				this.SwitchTitleView(true);
			}
			if (args.Event.Type == EventType.TwoButtonPress) {
				this.SwitchTitleView(false);
			}
		}

		public void MemoContentPressHandler (object obj, ButtonPressEventArgs args)
		{
			if (args.Event.Type == EventType.ButtonPress) {
				this.SwitchContentView(true);
			}
			if (args.Event.Type == EventType.TwoButtonPress) {
				this.SwitchContentView(false);
			}
		}
    }
}
