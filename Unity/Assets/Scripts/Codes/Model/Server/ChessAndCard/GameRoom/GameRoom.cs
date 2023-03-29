using System.Collections.Generic;

namespace ET
{
    public enum RoomType
    {
        Math = 1,
        Create = 2,
        Friends = 3
    }

    public class RoomStateType
    {
        public const int None = 0;//空闲
        public const int AwaitPerson = 1;//等待状态 等人齐
        public const int GameIn = 2;//游戏中
        public const int ReadyIn = 3;//准备中
    }

    public class GameRoom : Entity, IAwake,IDestroy
    {
        public int MathRoomId; //匹配房ID
        public int RoomId; //房间ID
        public int FriendsCircleId; //亲友圈ID
        public int RoomNumber; //房间人数
        public int NeedGlodCount; //所需金额
        public int RoomType; //房间类型
        public int CurrRoomStateType; //房间状态
        public bool IsPause; //房间是否暂停
        public int GameType; //游戏类型

        public int RoundCount;//总回合数
        public int RoundIndex;//当前回合

        public int CurrPlayerIndex;//当前操作玩家索引
        public List<GameCard> CurrCards = new List<GameCard>(); //当前出牌集合

        public bool IsHaveAI; //房间是否有AI

        public Dictionary<int, GameCard> ResidueCards = new Dictionary<int, GameCard>();//底牌
        public Dictionary<int, GameCard> OutCards = new Dictionary<int, GameCard>();//弃牌

        public Dictionary<int, GamePlayer> PlayerDictionary = new Dictionary<int, GamePlayer>();//玩家数组
        public List<int> CanOperatePlayers = new List<int>(); //当前可以操作的玩家
        public int CurrOperate;//当前操作

        public List<GameLog> GameLogs = new List<GameLog>();//当前回合游戏记录
    }
}