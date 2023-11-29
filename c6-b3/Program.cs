abstract class Edition
{
    string title, author;
    public abstract string CompareTo(Edition authors);
}
class Book : Edition
{
    int year;string publisher;
    public override string CompareTo(Edition authors)
    {
        
    }
}