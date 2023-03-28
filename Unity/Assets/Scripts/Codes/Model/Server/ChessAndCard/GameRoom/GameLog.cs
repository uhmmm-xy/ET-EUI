using System.Collections.Generic;

namespace ET
{
    public class MahjongCurrType
    {
        public const int Hu = 0;  //胡
        public const int Chow = 1; //吃
        public const int Pung = 2;//碰
        public const int Kong = 3;//杠
        public const int Fishing = 4;//听
        public const int PiaoCai = 5;//飘财
        public const int Take = 6;//抓牌
        public const int Out = 7;//弃牌
    }
    
    public class GameLog: Entity
    {
        public int GameType;
        public int CurrType; //操作类型
        public List<GameCard> CardList = new List<GameCard>(); //操作牌
        public List<GameCard> Before = new List<GameCard>();//之前牌型
        public List<GameCard> Later = new List<GameCard>();//操作之后
    }
}