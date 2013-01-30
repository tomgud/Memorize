using System.Text;
using System.Collections;

namespace Memorize.Items
{
    public class Memo : MemoComponent
    {
        protected string _content;
        protected ArrayList _attrs = new ArrayList();
        public ArrayList Attributes 
        {
            get
            {
                return this._attrs;
            }
        }

        public Memo() {}
        public Memo(string title, string content)
        {
            SetTitle(title);
            this._content = content;
        }

        public override string GetContent()
        {
            return this._content;
        }

        public override void SetContent(string s)
        {
            this._content = s;
        }

        // Adding an attribute to this Memo
        // Could make this a part of the interface
        // since MemoLists could theoritcally have
        // attributes as wells (tags f.example)
        public void AddAttribute(Attribute a)
        {
            this._attrs.Add(a);
        }

        public void RemoveAttribute(Attribute a)
        {
            this._attrs.Remove(a);
        }

        public override void Clear()
        {
            this._title = "";
            this._content = "";
            this._attrs.Clear();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(GetTitle().ToString() + " : " + GetContent().ToString());
            foreach (Attribute a in this._attrs) 
            {
                // sb.Append("  " + a.ToString());
                sb.Append("  " + a.Name + ": " + a.Value.ToString());
            }
            return sb.ToString();
        }
		
		public override IEnumerator GetEnumerator()
		{
			return new NullEnumerator(this);
		}
		
		private class NullEnumerator : IEnumerator 
		{
			private Memo _item;
			public NullEnumerator(Memo item)
			{
				_item = item;
			}
			
			public object Current 
			{
				get 
				{
					return _item;
				}
			}
			
			public void Reset ()
			{
				// Do nothing
			}
			
			public bool MoveNext ()
			{
				// Do Nothing
				return false;
			}
		}
    }
}
