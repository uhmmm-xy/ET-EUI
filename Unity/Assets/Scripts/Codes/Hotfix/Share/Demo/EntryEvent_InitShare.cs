namespace ET
{
    [Event(SceneType.Process)]
    public class EntryEvent_InitShare: AEvent<EventType.EntryEvent_InitShare>
    {
        protected override async ETTask Run(Scene scene, EventType.EntryEvent_InitShare args)
        {
            Root.Instance.Scene.AddComponent<NetThreadComponent>();
            Root.Instance.Scene.AddComponent<OpcodeTypeComponent>();
            Root.Instance.Scene.AddComponent<MessageDispatcherComponent>();
            Root.Instance.Scene.AddComponent<NumericWatcherComponent>();
            Root.Instance.Scene.AddComponent<AIDispatcherComponent>();
            Root.Instance.Scene.AddComponent<ClientSceneManagerComponent>();

            await ETTask.CompletedTask;
        }
    }
}