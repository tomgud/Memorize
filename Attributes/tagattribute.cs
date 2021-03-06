namespace Memorize 
{
    public class TagAttribute : Attribute
    {
        private string _value;

        public string Name 
        {
            get 
            {
                return "Tag";
            }
            set
            {
            }
        }

        public object Value 
        {
            get
            {
                return this._value;
            }
            set
            {
                if (value.GetType() == typeof(string))
                {
                    this._value = (string)value;
                } 
                else 
                {
                    // maybe throw an error here ?
                }
            }
        }

        public TagAttribute()
        {
            this._value = "";
        }
        public TagAttribute(string t)
        {
            this._value = t;
        }

        public int CompareTo(Attribute t)
        {
            if (t.GetType() == typeof(TagAttribute)) {
                string rval = (string)t.Value;
                return this._value.CompareTo(rval);
            } else {
                return -1;
            }
        }

    }
}
