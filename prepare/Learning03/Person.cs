public class Person
{
    private string _title = "Mr";
    private string _firstname = "Oluchukwu";
    private string _lastname = "Offor";
    
    public string GetInformalSignature()
    {
        return "Thanks " +  _firstname;
    }
    
    public string GetFormalSignature()
    {
        return "Sincerely " + GetFullName();
        
    }
    private string GetFullName()
    {
        return _title + " " + _firstname + "  " + _lastname;
    }
}

