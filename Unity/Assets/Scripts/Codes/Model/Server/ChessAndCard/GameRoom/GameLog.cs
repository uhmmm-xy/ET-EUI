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
        public int GameType; //游戏类型
        public GamePlayer Player; //操作人
        public List<GameCard> ResidueCards; //底牌
        public List<GameCard> OutCards; //弃牌
        public int GameCurrType; //操作类型
    }
}