namespace ET
{

    public enum AccountType 
    {
        None = 0, //一般玩家
        Black = 1, //黑名单
        GM = 2, //GM玩家
        Waiter = 3,  //陪玩
        Disab = 4, //删除用户
    }

    [ComponentOf]
    [ChildType]
    public class Account : Entity,IAwake
    {

        public string AccountUUID; //第三方ID

        public long CreateTime; //创建时间

        public int AccountType;
    }
}
