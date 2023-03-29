namespace ET
{

    public class PokerType
    {
        public const int Spade = 0;
        public const int Heart = 1;
        public const int Plum = 2;
        public const int Square = 3;
        public const int Joker = 4;
    }

    public class MahjongType
    {
        public const int Dots = 0;
        public const int Bamboo = 1;
        public const int Characher = 2;
        public const int Arrow = 3;
        public const int Wind = 4;
        public const int Flower = 5;
    }

    public class GameCard : Entity
    {
        public int CardType;
        public int CardValue;
    }
}