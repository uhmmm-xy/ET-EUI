using System.Collections.Generic;

namespace ET
{
    [ChildOf(typeof(GameRoom))]
    public class RoomConfigComponent : Entity,IAwake
    {
        public int GameCardType; //游戏牌类型 ？  扑克or麻将

        public List<CardType> CardType; //牌花色

        public int CardCount; //牌数量

        public List<GameCard> Cards; //牌库

    }

    public struct CardType 
    {
        public int Type;
        public int MinValue;
        public int MaxValue;
        public int Count;
    }
}
