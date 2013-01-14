using System;
namespace Memorize 
{
    public class DateAttribute : Attribute
    {
        DateTime _date;
        string _name;
        public string Name 
        {
            get
            {
                return _name;
            }
            set 
            {
                _name = value;
            }
        }
        public object Value 
        {
            get 
            {
                return _date;
            }
            set
            {
                if (value.GetType() == typeof(DateTime))
                {
                    _date = (DateTime)value;
                }
                else
                {
                    // Maybe throw an error here ?
                }
            }
        }

        public int CompareTo(Attribute t)
        {
            return 0;
        }

    }
}
