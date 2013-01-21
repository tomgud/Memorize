using System;
using Memorize;
using Memorize.Items;
using Gtk;

namespace Memorize.DesktopUI
{
    public class MemoItemDisplay 
    {
        private Memo _item;
        public Memo Item
        {
            get
            {
                return _item;
            }
        }

        public MemoItemDisplay(Memo m)
        {
            this._item = m;
        }

        public void Display(HBox parent)
        {
            VBox memoContent = new VBox(false, 5);

            // Memo Title
            Alignment titleAlign = new Alignment(0, 0, 0, 0);
            titleAlign.SetSizeRequest(80, 25);
            Label title = new Label();
            title.Text = this._item.GetTitle();
            title.SetAlignment(0, 0);
            titleAlign.Add(title);
			titleAlign.ShowAll();

            
            Alignment contentAlign = new Alignment(0, 0, 0, 1);
            Label content = new Label();
            content.Text = this._item.GetContent();
            content.SetSizeRequest(200, 140);
            content.SetAlignment(0, 0);
            content.LineWrap = true;
            content.Justify = Justification.Fill;
            contentAlign.Add(content);
			contentAlign.ShowAll();
            
            // PackStart (child, expand, fill, padding)
            memoContent.PackStart(titleAlign, false, false, 4);
            memoContent.PackStart(contentAlign, false, false, 4);
            memoContent.SetSizeRequest(220, 200);
			memoContent.ShowAll();

            parent.Add(memoContent); 
        }

    }

}
