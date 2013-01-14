namespace Memorize 
{
    public interface Attribute 
    {
        string Name
        {
            get;
            set;
        }
        object Value
        {
            get;
            set;
        }
        int CompareTo(Attribute rval);
    }
}
