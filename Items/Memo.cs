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

        public override void AddAttribute(Attribute a)
        {
            this._attrs.Add(a);
        }

        public override void Clear()
        {
            this._title = "";
            this._content = "";
        }

        public override string ToString()
        {
            return GetTitle().ToString() + " : " + GetContent().ToString();
        }

    }
}
