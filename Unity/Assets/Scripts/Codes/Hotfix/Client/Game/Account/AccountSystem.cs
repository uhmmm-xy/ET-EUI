namespace ET;

[FriendOf(typeof(Account))]
public static class AccountSystem
{
    [ObjectSystem]
    public class AccountAwakeSystem:AwakeSystem<Account,string>
    {
        protected override void Awake(Account self,string AccountId)
        {
            self.AccountID = AccountId;
            self.CraeteTime = TimeHelper.ServerNow();
            self.AccountType = (int)AccountType.none;
        }
    }
}

