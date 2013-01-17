using System;
using Gdk;
using Gtk;

namespace Memorize 
{
    public class App
    {
        private static Gtk.StatusIcon icon;
        private static Gtk.Window window;
        public static void Main() 
        {
            Application.Init();

            // Create the Window
            window = new Gtk.Window("Memorize");
            window.DeleteEvent += delegate { Application.Quit(); };
            window.Resize(500, 500);

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
            table1.Attach(bottomLeft, 0, 1, 1, 2, Gtk.AttachOptions.Expand,
                    Gtk.AttachOptions.Expand, 10, 10);

            // Ideally here I would attach something that inherits a widget
            // and is a menu for creating new memos
            table1.Attach(bottomRight, 1, 2, 1, 2, Gtk.AttachOptions.Fill,
                    Gtk.AttachOptions.Shrink, 10, 10);

            window.Add(table1);
            window.ShowAll();
            Application.Run();
        }
    }
}
