namespace ET;

public enum AccountType
{
    none, //一般玩家
    black,//黑名单
    gm,//Gm玩家
    waiter //陪玩
}

public class Account : Entity,IAwake<string>
{
    public string AccountID;

    public long CraeteTime;

    public int AccountType;
}