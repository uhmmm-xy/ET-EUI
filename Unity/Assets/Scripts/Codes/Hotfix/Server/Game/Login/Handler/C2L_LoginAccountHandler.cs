using ET.Server;
using MongoDB.Bson;

namespace ET
{
    [MessageHandler(SceneType.Login)]
    public class C2L_LoginAccountHandler: AMRpcHandler<C2L_LoginAccount, L2C_LoginAccount>
    {
        protected override async ETTask Run(Session session, C2L_LoginAccount request, L2C_LoginAccount response)
        {
            StartSceneConfig config = RealmGateAddressHelper.GetGate(session.DomainZone());
            Log.Debug($"gate address: {MongoHelper.ToJson(config)}");
            
            

            G2L_GetLoginKey g2AGetLoginKey =
                    (G2L_GetLoginKey)await ActorMessageSenderComponent.Instance.Call(config.InstanceId,
                        new L2G_GetLoginKey() { AccountId = request.AccountId });

            response.Address = config.InnerIPOutPort.ToString();
            response.Key = g2AGetLoginKey.Key;
            response.GateId = g2AGetLoginKey.GateId;
        }
    }
}