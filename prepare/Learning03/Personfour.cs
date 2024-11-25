public class Personfour
{
    private string _title;
    private string _firstname;
    private string _lastname;
    
    public Personfour()
    {
        _title = "";
        _firstname = "Anonymous";
        _lastname = "Unknown";
    }
    
    public Personfour(string firstname, string lastname)
    {
        _title = "";
        _firstname = firstname;
        _lastname = lastname;
    }
     public Personfour(string title, string firstname, string lastname)
    {
        _title = title;
        _firstname = firstname;
        _lastname = lastname;
    }
}
