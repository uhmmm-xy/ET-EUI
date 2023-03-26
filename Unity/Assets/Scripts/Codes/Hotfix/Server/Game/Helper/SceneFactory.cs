using System.Net;
using ET.Server;

namespace ET;

public static class SceneFactory
{
    public static async ETTask<Scene> CreateServerScene(Entity parent, long id, long instanceId, int zone, string name, SceneType sceneType,
    StartSceneConfig startSceneConfig = null)
    {
        await ETTask.CompletedTask;
        Scene scene = EntitySceneFactory.CreateScene(id, instanceId, zone, sceneType, name, parent);

        scene.AddComponent<DBManagerComponent>();

        switch (scene.SceneType)
        {
            case SceneType.Gate:
            case SceneType.Login:
                scene.AddComponent<NetServerComponent, IPEndPoint>(startSceneConfig.InnerIPOutPort);
                break;
            case SceneType.Account:
            case SceneType.Game:
            case SceneType.GM:
                break;
        }

        return scene;
    }
}