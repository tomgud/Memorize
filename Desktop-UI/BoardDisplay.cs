using System;
using System.Collections;
using Gdk;
using Gtk;

namespace Memorize.DesktopUI
{
    public class BoardDisplay 
    {
        private VBox _boardHolder;
        private HBox _board;
        private int count = 0;
        private ArrayList memos;
        public VBox Board 
        {
            get 
            {
                return _boardHolder;
            }
        }
        public BoardDisplay() 
        {
            //_boardHolder = new Alignment(0, 0, 0, 0);
            _boardHolder = new VBox(true, 5);
            _boardHolder.SetSizeRequest(300, 300);
            _board = new HBox(true, 5);
            memos = new ArrayList();
        }

        public void DrawBoard() 
        {
            foreach (MemoItemDisplay dis in memos)
            {
                dis.Display(this._board);
            }

            Adjustment sa = new Adjustment(0.0, 0.0, 101.0, 0.1, 1.0, 10.0);
            HScrollbar sb = new HScrollbar(sa);
            this._boardHolder.PackStart(this._board);
            this._boardHolder.PackStart(sb);
        }

        public void AddMemoDisplay(MemoItemDisplay mid)
        {
            this.memos.Add(mid);
        }

    }

}
