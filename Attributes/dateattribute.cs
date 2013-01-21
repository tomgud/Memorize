using System;
namespace Memorize 
{
    public class DateAttribute : Attribute
    {
        DateTime _date;
        public string Name 
        {
            get
            {
                return "Date";
            }
            set 
            {
            }
        }
        public object Value 
        {
            get 
            {
                return (object)_date;
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

        public DateAttribute(DateTime date)
        {
            this._date = date;
        }

        public int CompareTo(Attribute t)
        {
            if (t.GetType() == typeof(DateAttribute))
                return this._date.CompareTo((DateTime)t.Value);
            else
                return -1;
        }

    }
}
