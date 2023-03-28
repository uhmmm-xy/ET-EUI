using System.ComponentModel;

namespace ET
{
    public static class GameType
    {
        //麻将从1000开始
        [Description("杭州麻将")]
        public const int HZMahjong = 1001;//杭州麻将
        
        //纸牌从2000开始
        [Description("四副牌")]
        public const int SiFuPai = 2001;//四副牌
    }
}