using System;


namespace ET.Server
{
    [ActorMessageHandler(SceneType.Gate)]
    public class L2G_GetLoginKeyHandler : AMActorRpcHandler<Scene, L2G_GetLoginKey, G2L_GetLoginKey>
    {
        protected override async ETTask Run(Scene scene, L2G_GetLoginKey request, G2L_GetLoginKey response)
        {
            await ETTask.CompletedTask;
            long key = RandomGenerator.RandInt64();
            scene.GetComponent<GateSessionKeyComponent>().Add(key, request.AccountId);
            response.Key = key;
            response.GateId = scene.Id;
        }
    }
}