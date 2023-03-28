namespace ET
{
    [ComponentOf(typeof(Scene))]
    public class AccountInfoComponent : Entity,IAwake
    {
        public string Token;
        public long AccountId;
    }
}
