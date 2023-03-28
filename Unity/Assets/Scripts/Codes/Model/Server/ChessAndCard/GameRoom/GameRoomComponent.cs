using System.Collections.Generic;

namespace ET
{
    public class GameRoomComponent : Entity,IAwake
    {
        public readonly List<int> RoomIds = new List<int>();
        public readonly Dictionary<int, GameRoom> GameRooms = new Dictionary<int, GameRoom>();

        public long CurrTime;
    }    
}
