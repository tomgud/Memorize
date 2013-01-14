namespace Memorize 
{
    public class TagAttribute 
    {
        private string _name;
        private string _value;

        public string Name 
        {
            get 
            {
                return this._name;
            }
            set
            {
                this._name = value;
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
