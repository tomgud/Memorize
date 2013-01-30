using System;
using System.Collections;
using System.Text;

namespace Memorize.Items
{

    public class MemoList : MemoComponent, IEnumerable
    {

        public enum MemoListSortingEnumeration
        {
            Title,
            Content,
            Date,
            Size
        }
        private ArrayList items = new ArrayList();
        public MemoList() { }

        public override void Add(MemoComponent mc)
        {
            // We might want to prevent looping here ...
            // since we can add any MemoComponent, we can
            // add a composite A to composite B, and then
            // composite B to A, making a loop between them
            // printing them out, results in a infintie loop
            // Maybe, a deep copy of the objects ???
            try {
                if (!Contains(mc) && !mc.Contains(this)) {
                    // This container does not have mc
                    // and mc does not contain this
                    // OK to add
                    this.items.Add(mc);
                }
            } catch (InvalidOperationException ex) {
                // mc does not have the operation Contains 
                // so it must be a Memo, not a MemoList. OK to add
                // Might want to log this ...
                this.items.Add(mc);
            }
        }

        public override void Remove(MemoComponent mc)
        {
            this.items.Remove(mc);
        }

        public override MemoComponent GetChild(int i)
        {
            if (this.items.Count > i && i >= 0)
            {
                return (MemoComponent)this.items[i];
            } else {
                throw new System.IndexOutOfRangeException();
            }
        }

        public int GetCount() 
        {
            return this.items.Count;
        }

        public override void Clear()
        {
            this._title = "";
            this.items.Clear();
        }

        public override bool Contains(MemoComponent m) 
        {
            return this.items.Contains(m);
        }

        public void Sort(MemoListSortingEnumeration index)
        {
            IComparer mc;
            switch (index) {
                case MemoListSortingEnumeration.Content :
                    //mc = new MemoContentComparator();
                    //break;
                case MemoListSortingEnumeration.Title :
                default:
                    mc = new MemoTitleComparator();
                    break;
            }
            this.items.Sort(mc);
        }

        public override IEnumerator GetEnumerator() 
        {
            return this.items.GetEnumerator();
        }

        public override string ToString() 
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Composite: " + GetTitle() + "\n");
            foreach (MemoComponent mc in this)
            {
                sb.Append(mc.ToString() + "\n");
            }
            return sb.ToString();
        }

        private class MemoTitleComparator : IComparer 
        {
            int IComparer.Compare(Object x, Object y) 
            {
                MemoComponent m_x = (MemoComponent)x;
                MemoComponent m_y = (MemoComponent)y;
                return m_x.GetTitle().CompareTo(m_y.GetTitle());
            }
        }
        /*
        private class MemoContentComparator : IComparer 
        {
            int IComparer.Compare(Object x, Object y) 
            {
                Memo m_x = (Memo)x;
                Memo m_y = (Memo)y;
                return m_x.Content.CompareTo(m_y.Content);
            }
        }
        */
    }
}
