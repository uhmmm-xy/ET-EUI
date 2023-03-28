using System;

namespace ET
{
    public class C2A_LoginAccountHandler : AMRpcHandler<C2A_LoginAccount, A2C_LoginAccount>
    {
        protected override async ETTask Run(Session session, C2A_LoginAccount request, A2C_LoginAccount response, Action reply)
        {
            if (session.DomainScene().SceneType != SceneType.Account)
            {
                Log.Error($"错误的Scene。当前的Scene为：{session.DomainScene().SceneType}");
                session.Dispose();
            }

            var accountInfoList = await DBManagerComponent.Instance.GetZoneDB(session.DomainZone()).Query<Account>(d => d.AccountUUID.Equals(request.AccountUUID));

            Account account = null;
            if (accountInfoList != null && accountInfoList.Count > 0)
            {
                account = accountInfoList[0];
                session.AddChild(account);


            }
            else
            {
                account = session.AddChild<Account>();
                account.AccountUUID = request.AccountUUID;
                account.AccountType = (int)AccountType.None;
                account.CreateTime = TimeHelper.ServerNow();

                await DBManagerComponent.Instance.GetZoneDB(session.DomainZone()).Save<Account>(account);

            }

            string token = TimeHelper.ServerNow().ToString() + RandomHelper.RandomNumber(int.MinValue, int.MaxValue).ToString();

            await ETTask.CompletedTask;
        }
    }
}
