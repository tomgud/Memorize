using System.Text;
using System.Collections;

namespace Memorize {
    public class Memo {
        private string title = "";
        private string content = "";
        private ArrayList attributes = new ArrayList();
        public ArrayList Attributes
        {
            get 
            {
                return this.attributes;
            }
        }
        public string Content
        {
            get 
            {
                return this.content;
            }
            set 
            {
                this.content = value;
            }
        }
        public string Title 
        {
            get 
            {
                return this.title;
            }
            set 
            {
                this.title = value;
            }
        }

        public Memo() { }
        public Memo(string t, string c) 
        {
            this.title = t;
            this.content = c;
        }

        public void AddAttribute(Attribute a) 
        {
            this.attributes.Add(a);
        }
        
        public override string ToString()
        {
            return this.title.ToString() + " : " + this.content.ToString();
        }
    }
}
