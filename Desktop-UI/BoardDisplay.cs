using System;
using System.Collections;
using Gdk;
using Gtk;

namespace Memorize.DesktopUI
{
    public class BoardDisplay 
    {
        private Alignment _boardHolder;
        private HBox _board;
        private int count = 0;
        private ArrayList memos;
        public Alignment Board 
        {
            get 
            {
                return _boardHolder;
            }
        }
        public BoardDisplay() 
        {
            _boardHolder = new Alignment(0, 0, 0, 0);
            _board = new HBox(true, 5);
            memos = new ArrayList();
        }

        public void DrawBoard() 
        {
            foreach (MemoItemDisplay dis in memos)
            {
                dis.Display(this._board);
            }
            this._boardHolder.Add(this._board);
        }

        public void AddMemoDisplay(MemoItemDisplay mid)
        {
            this.memos.Add(mid);
        }

    }

}
