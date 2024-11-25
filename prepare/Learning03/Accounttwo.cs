public class Accounttwo
{
    private List<int> _transaction = new List<int> {10, 50, 2000};
    
    
    public void Deposit(int amount){
        _transaction.Add(amount);
    }
    public void SetBalance(int amount){
    }
    public void GetBalance()
    {
    }
}