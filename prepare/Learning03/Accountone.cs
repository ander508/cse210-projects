public class Accountone
{
    private int _balance;
    
    public void Deposit(int amount)
    {
    }
    
    public void SetBalance(int amount)
    {
        _balance = 500;
        _balance  = _balance + amount;
    }
    
    public int GetBalance()
    {
        return _balance;
    }
}