using System;
using System.Collections;
using Gdk;
using Gtk;

namespace Memorize.DesktopUI
{
    public class BoardDisplay 
    {
        private HBox _board;
        private ArrayList memos;
        public HBox Board 
        {
            get 
            {
                return _board;
            }
        }
        public BoardDisplay(HBox board) 
        {
			_board = board;
            memos = new ArrayList();
        }

        public void DrawBoard() 
        {
            foreach (MemoItemDisplay dis in memos)
            {
                dis.Display(this._board);
            }
			this._board.ShowAll ();
        }

        public void AddMemoDisplay(MemoItemDisplay mid)
        {
            this.memos.Add(mid);
        }

    }

}
