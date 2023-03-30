using System.Collections.Generic;

namespace ET
{
    public class GameConfigComponent : Entity,IAwake<string>
    {
        public int GameType; //游戏类型
        public string GameName; 

        public int ConfigType; //详细类型

        public Dictionary<string, int> Config; //配置内容
    }
}
