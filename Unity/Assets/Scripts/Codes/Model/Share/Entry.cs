namespace ET
{
    namespace EventType
    {
        public struct EntryEvent_InitShare
        {
        }   
        
        public struct EntryEvent_InitServer
        {
        } 
        
        public struct EntryEvent_InitClient
        {
        } 
    }
    
    public static class Entry
    {
        public static void Init()
        {
            
        }
        
        public static void Start()
        {
            StartAsync().Coroutine();
        }
        
        private static async ETTask StartAsync()
        {
            WinPeriod.Init();
            
            MongoHelper.Init();
            ProtobufHelper.Init();
            
            Game.AddSingleton<NetServices>();
            Game.AddSingleton<Root>();
            await Game.AddSingleton<ConfigComponent>().LoadAsync();

            await EventSystem.Instance.PublishAsync(Root.Instance.Scene, new EventType.EntryEvent_InitShare());
            await EventSystem.Instance.PublishAsync(Root.Instance.Scene, new EventType.EntryEvent_InitServer());
            await EventSystem.Instance.PublishAsync(Root.Instance.Scene, new EventType.EntryEvent_InitClient());
        }
    }
}