namespace ET
{
    [FriendOf(typeof(GameRoom))]
    public static class GameRoomSystem
    {

        public static void Init(this GameRoom self) 
        { 

        }

        /// <summary>
        /// 游戏开始
        /// </summary>
        /// <param name="self"></param>
        public static void BeginGame(this GameRoom self)
        {

        }


        /// <summary>
        /// 游戏结束
        /// </summary>
        /// <param name="self"></param>
        public static void EndGame(this GameRoom self) { }


        /// <summary>
        /// 发牌
        /// </summary>
        /// <param name="self"></param>
        public static void DealCard(this GameRoom self)
        {
        }


        /// <summary>
        /// 洗牌
        /// </summary>
        /// <param name="self"></param>
        public static void ShuffleCard(this GameRoom self)
        {

        }

        /// <summary>
        /// 下一回合
        /// </summary>
        /// <param name="self"></param>
        public static void NextRound(this GameRoom self) { }


        /// <summary>
        /// 当前操作玩家
        /// </summary>
        /// <param name="self"></param>
        /// <returns>当前玩家</returns>
        public static GamePlayer GetNowPlayer(this GameRoom self)
        {
            return self.PlayerDictionary[self.CurrPlayerIndex];
        }


        /// <summary>
        /// 验证操作
        /// </summary>
        /// <param name="self"></param>
        /// <returns>存不存在</returns>
        public static bool CheckOperate(this GameRoom self) 
        {
            return true;
        }

        /// <summary>
        /// 验证回合是否结束
        /// </summary>
        /// <param name="self"></param>
        /// <returns>是否结束</returns>
        public static bool CheckRoundOver(this GameRoom self) 
        { 
            return true;
        }


        public class GameRoomDestroySystem : DestroySystem<GameRoom>
        {
            protected override void Destroy(GameRoom self)
            {
                foreach (var item in self.PlayerDictionary)
                {
                    item.Value?.Dispose();
                }
                self.PlayerDictionary.Clear();

                foreach(var item in self.ResidueCards) 
                {
                    item.Value?.Dispose();
                }
                self.ResidueCards.Clear();

                foreach (var item in self.OutCards)
                {
                    item.Value?.Dispose();
                }
                self.OutCards.Clear();

                foreach (var item in self.CurrCards)
                {
                    item?.Dispose();
                }
                self.CurrCards.Clear();

                foreach (var item in self.GameLogs)
                {
                    item?.Dispose();
                }
                self.GameLogs.Clear();

                self.Dispose();
            }
        }

    }
}
