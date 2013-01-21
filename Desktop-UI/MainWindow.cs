using System;
using Gtk;
using Memorize.Items;

namespace Memorize.DesktopUI 
{
	public partial class MainWindow: Gtk.Window
	{	
		public MainWindow (): base (Gtk.WindowType.Toplevel)
		{
			Build ();
			BoardDisplay mBoard = new BoardDisplay(MemoBoard);
            mBoard.AddMemoDisplay(new MemoItemDisplay(new Memo("1", "Muna ad kaupa mjolk")));
            mBoard.AddMemoDisplay(new MemoItemDisplay(new Memo("2", "two")));
            mBoard.AddMemoDisplay(new MemoItemDisplay(new Memo("3", "three is an incredibly long text blah blah blah")));
            mBoard.AddMemoDisplay(new MemoItemDisplay(new Memo("4", "four")));
            mBoard.DrawBoard();
		}
		protected void OnDeleteEvent (object sender, DeleteEventArgs a)
		{
			Application.Quit ();
			a.RetVal = true;
		}
			/*
            Application.Init();

            // Create the Window
            window = new Gtk.Window("Memorize");
            window.DeleteEvent += delegate { Application.Quit(); };
            window.Resize(800, 600);

            // Status bar ...
            icon = new StatusIcon(new Pixbuf("res/icon.png"));
            icon.Visible = true;
            icon.Activate += delegate { window.Visible = !window.Visible; };
            icon.Tooltip = "Yo imma let you finish";

            // Table view
            Table table1 = new Table(2, 2, false);
            Label top = new Label();
            top.Text = "Buttons shortcuts, statuses, etc...";
            Label bottomLeft= new Label();
            bottomLeft.Text = "A \"cardboard\" of memos will be hung here.";
            Label bottomRight = new Label();
            bottomRight.Text = "Menu for creating memo \nlists, projects, memos...";

            // Here I could attach some informations, buttons
            // something that is general to all memos ?
            table1.Attach(top, 0, 2, 0, 1, Gtk.AttachOptions.Expand,
                    Gtk.AttachOptions.Fill, 10, 10);
            
            // Here I would create a specific widget that specializes
            // in displaying memos
            
            BoardDisplay mBoard = new BoardDisplay();
            mBoard.AddMemoDisplay(new MemoItemDisplay(new Memo("1", "one")));
            mBoard.AddMemoDisplay(new MemoItemDisplay(new Memo("2", "two")));
            mBoard.AddMemoDisplay(new MemoItemDisplay(new Memo("3", "three is an incredibly long text blah blah blah")));
            mBoard.AddMemoDisplay(new MemoItemDisplay(new Memo("4", "four")));
            mBoard.DrawBoard();
            table1.Attach(mBoard.Board, 0, 1, 1, 2, Gtk.AttachOptions.Expand,
                    Gtk.AttachOptions.Expand, 10, 10);

            // Ideally here I would attach something that inherits a widget
            // and is a menu for creating new memos
            table1.Attach(bottomRight, 1, 2, 1, 2, Gtk.AttachOptions.Fill,
                    Gtk.AttachOptions.Fill, 1, 1);

            window.Add(table1);
            window.ShowAll();
            Application.Run();
			*/
	}
}