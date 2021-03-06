
// This file has been generated by the GUI designer. Do not modify.
namespace Memorize.DesktopUI
{
	public partial class MainWindow
	{
		private global::Gtk.VBox VBoxContainer;
		private global::Gtk.Alignment TopAlignment;
		private global::Gtk.HBox CenterHBox;
		private global::Gtk.Alignment LeftAlignment;
		private global::Gtk.Alignment CenterContainer;
		private global::Gtk.ScrolledWindow GtkScrolledWindow1;
		private global::Gtk.HBox MemoBoard;
		private global::Gtk.Alignment MenuBarAlignment;
		private global::Gtk.Fixed MenuBarContainer;
		private global::Gtk.Label MenuBarTitle;
		private global::Gtk.Button NewMemo;
		private global::Gtk.Button MenuBarSaveAll;
		private global::Gtk.Alignment BottomAlignment;
        
		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget Memorize.DesktopUI.MainWindow
			this.WidthRequest = 960;
			this.HeightRequest = 800;
			this.Name = "Memorize.DesktopUI.MainWindow";
			this.Title = global::Mono.Unix.Catalog.GetString ("Memorize");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			this.BorderWidth = ((uint)(2));
			this.DefaultWidth = 960;
			this.DefaultHeight = 800;
			// Container child Memorize.DesktopUI.MainWindow.Gtk.Container+ContainerChild
			this.VBoxContainer = new global::Gtk.VBox ();
			this.VBoxContainer.Name = "VBoxContainer";
			this.VBoxContainer.Spacing = 6;
			// Container child VBoxContainer.Gtk.Box+BoxChild
			this.TopAlignment = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.TopAlignment.HeightRequest = 30;
			this.TopAlignment.Name = "TopAlignment";
			this.VBoxContainer.Add (this.TopAlignment);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.VBoxContainer [this.TopAlignment]));
			w1.Position = 0;
			w1.Expand = false;
			// Container child VBoxContainer.Gtk.Box+BoxChild
			this.CenterHBox = new global::Gtk.HBox ();
			this.CenterHBox.Name = "CenterHBox";
			this.CenterHBox.Spacing = 6;
			// Container child CenterHBox.Gtk.Box+BoxChild
			this.LeftAlignment = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.LeftAlignment.WidthRequest = 1;
			this.LeftAlignment.Name = "LeftAlignment";
			this.CenterHBox.Add (this.LeftAlignment);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.CenterHBox [this.LeftAlignment]));
			w2.Position = 0;
			w2.Expand = false;
			// Container child CenterHBox.Gtk.Box+BoxChild
			this.CenterContainer = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.CenterContainer.Name = "CenterContainer";
			// Container child CenterContainer.Gtk.Container+ContainerChild
			this.GtkScrolledWindow1 = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow1.Name = "GtkScrolledWindow1";
			this.GtkScrolledWindow1.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow1.Gtk.Container+ContainerChild
			global::Gtk.Viewport w3 = new global::Gtk.Viewport ();
			w3.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child GtkViewport1.Gtk.Container+ContainerChild
			this.MemoBoard = new global::Gtk.HBox ();
			this.MemoBoard.Name = "MemoBoard";
			this.MemoBoard.Homogeneous = true;
			this.MemoBoard.Spacing = 6;
			w3.Add (this.MemoBoard);
			this.GtkScrolledWindow1.Add (w3);
			this.CenterContainer.Add (this.GtkScrolledWindow1);
			this.CenterHBox.Add (this.CenterContainer);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.CenterHBox [this.CenterContainer]));
			w7.Position = 1;
			// Container child CenterHBox.Gtk.Box+BoxChild
			this.MenuBarAlignment = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.MenuBarAlignment.WidthRequest = 200;
			this.MenuBarAlignment.Name = "MenuBarAlignment";
			// Container child MenuBarAlignment.Gtk.Container+ContainerChild
			this.MenuBarContainer = new global::Gtk.Fixed ();
			this.MenuBarContainer.HeightRequest = 750;
			this.MenuBarContainer.Name = "MenuBarContainer";
			this.MenuBarContainer.HasWindow = false;
			// Container child MenuBarContainer.Gtk.Fixed+FixedChild
			this.MenuBarTitle = new global::Gtk.Label ();
			this.MenuBarTitle.Name = "MenuBarTitle";
			this.MenuBarTitle.LabelProp = global::Mono.Unix.Catalog.GetString ("Menu");
			this.MenuBarContainer.Add (this.MenuBarTitle);
			global::Gtk.Fixed.FixedChild w8 = ((global::Gtk.Fixed.FixedChild)(this.MenuBarContainer [this.MenuBarTitle]));
			w8.X = 10;
			w8.Y = 10;
			// Container child MenuBarContainer.Gtk.Fixed+FixedChild
			this.NewMemo = new global::Gtk.Button ();
			this.NewMemo.WidthRequest = 180;
			this.NewMemo.HeightRequest = 60;
			this.NewMemo.CanFocus = true;
			this.NewMemo.Name = "NewMemo";
			this.NewMemo.UseUnderline = true;
			this.NewMemo.Label = global::Mono.Unix.Catalog.GetString ("New Memo");
			this.MenuBarContainer.Add (this.NewMemo);
			global::Gtk.Fixed.FixedChild w9 = ((global::Gtk.Fixed.FixedChild)(this.MenuBarContainer [this.NewMemo]));
			w9.X = 10;
			w9.Y = 40;
			// Container child MenuBarContainer.Gtk.Fixed+FixedChild
			this.MenuBarSaveAll = new global::Gtk.Button ();
			this.MenuBarSaveAll.WidthRequest = 180;
			this.MenuBarSaveAll.HeightRequest = 60;
			this.MenuBarSaveAll.CanFocus = true;
			this.MenuBarSaveAll.Name = "MenuBarSaveAll";
			this.MenuBarSaveAll.UseUnderline = true;
			this.MenuBarSaveAll.Label = global::Mono.Unix.Catalog.GetString ("Save notes");
			this.MenuBarContainer.Add (this.MenuBarSaveAll);
			global::Gtk.Fixed.FixedChild w10 = ((global::Gtk.Fixed.FixedChild)(this.MenuBarContainer [this.MenuBarSaveAll]));
			w10.X = 10;
			w10.Y = 110;
			this.MenuBarAlignment.Add (this.MenuBarContainer);
			this.CenterHBox.Add (this.MenuBarAlignment);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.CenterHBox [this.MenuBarAlignment]));
			w12.Position = 2;
			w12.Expand = false;
			this.VBoxContainer.Add (this.CenterHBox);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.VBoxContainer [this.CenterHBox]));
			w13.Position = 1;
			w13.Expand = false;
			w13.Fill = false;
			// Container child VBoxContainer.Gtk.Box+BoxChild
			this.BottomAlignment = new global::Gtk.Alignment (0.5F, 0.5F, 1F, 1F);
			this.BottomAlignment.HeightRequest = 1;
			this.BottomAlignment.Name = "BottomAlignment";
			this.VBoxContainer.Add (this.BottomAlignment);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.VBoxContainer [this.BottomAlignment]));
			w14.Position = 2;
			w14.Expand = false;
			this.Add (this.VBoxContainer);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Show ();
			this.DeleteEvent += new global::Gtk.DeleteEventHandler (this.OnDeleteEvent);
			this.NewMemo.Clicked += new global::System.EventHandler (this.NewMemoHandler);
		}
	}
}
