using System;
using System.Collections;

namespace Memorize {
    public class MemoList : IEnumerable {
        public enum MemoListSortingEnumerator {
            Title,
            Content,
            Date,
            Size
        };
        private ArrayList items = new ArrayList();
        private ArrayList Items 
        {
            get 
            {
                return items;
            }
        }
        
        public MemoList() 
        {

        }


        public void AddMemo(Memo m) 
        {
            this.items.Add(m);
        }

        public void RemoveMemo(Memo m)
        {
            this.items.Remove(m);
        }

        public void RemoveMemoAt(int i) 
        {
           this.items.RemoveAt(i);
        } 

        public void Clear() 
        {
            this.items.Clear();
        }

        public void AddList(MemoList ml) 
        {
            foreach (Memo item in ml) 
            {
                if (!this.items.Contains(item))
                    this.items.Add(item);
            }
        }

        public bool Contains(Memo m) 
        {
            return this.items.Contains(m);
        }

        public void Sort(MemoListSortingEnumerator index)
        {
            IComparer mc;
            switch (index) {
                case MemoListSortingEnumerator.Content :
                    mc = new MemoContentComparator();
                    break;
                case MemoListSortingEnumerator.Title :
                default:
                    mc = new MemoTitleComparator();
                    break;
            }
            this.items.Sort(mc);
        }

        public IEnumerator GetEnumerator() 
        {
            return this.items.GetEnumerator();
        }

        private class MemoTitleComparator : IComparer 
        {
            int IComparer.Compare(Object x, Object y) 
            {
                Memo m_x = (Memo)x;
                Memo m_y = (Memo)y;
                return m_x.Title.CompareTo(m_y.Title);
            }
        }

        private class MemoContentComparator : IComparer 
        {
            int IComparer.Compare(Object x, Object y) 
            {
                Memo m_x = (Memo)x;
                Memo m_y = (Memo)y;
                return m_x.Content.CompareTo(m_y.Content);
            }
        }
    }
}
