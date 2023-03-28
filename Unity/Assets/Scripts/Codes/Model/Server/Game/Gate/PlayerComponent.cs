using System.Collections.Generic;
using System.Linq;

namespace ET.Server
{
    [ComponentOf(typeof(Scene))]
    public class PlayerComponent : Entity, IAwake, IDestroy
    {
        public readonly Dictionary<long, Account> idPlayers = new Dictionary<long, Account>();
    }
}