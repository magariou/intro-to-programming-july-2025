using Banking.Domain;

namespace Banking.Tests.LoyaltyProgram;

public class GoldAccountDeposits
{
    [Fact]
    public void GoldAccountsGetBonusOnTheirDeposits()
    {
        var account = new BankAccount();
        var accountValue = account.GetBalance();
        account.Deposit(100M);
        var accountNewValue = account.GetBalance();

        Assert.Equal((accountValue*1.20M), accountNewValue);



    }
}
