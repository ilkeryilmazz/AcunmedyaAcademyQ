namespace ObjectOriantdProgramming.Entities.BankAccount
{
    public class CheckingAccount : BankAccount
    {
        public CheckingAccount(int ıd, string accountHolder, double balance) : base(ıd, accountHolder, balance)
        {
        }

        public override double CalculateInterest()
        {
            throw new BusinessException("Checking account does not have interest");
        }
    }
}
