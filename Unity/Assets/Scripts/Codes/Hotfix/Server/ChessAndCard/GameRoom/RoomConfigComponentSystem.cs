using System.Collections.Generic;

namespace ET
{
    [FriendOf(typeof(RoomConfigComponent))]
    public static class RoomConfigComponentSystem
    {
        public static void Init(this RoomConfigComponent self)
        {
            if(self.Cards == null) 
            {
                self.Cards  = new List<GameCard>();
            }

            for (int i = 0; i < self.CardCount; i++)
            {
                foreach (var item in self.CardType)
                {
                    for (int z = item.MinValue; z <= item.MaxValue; z++)
                    {
                        for (var j = 0; j < item.Count; j++)
                        {
                            self.Cards.Add(new GameCard() { CardType = item.Type, CardValue = z });
                        }
                    }
                }
            }

        }
    }
}
