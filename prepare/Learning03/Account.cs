public class Account
{
    public int _balance = 0;
    
    public List<int> _transaction = new List<int>();
    
    public int Deposit(int amount)
    {
      return _balance = _balance + amount;
    }
    
   
}