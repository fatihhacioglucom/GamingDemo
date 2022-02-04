using GamingDemo.Abstract;
using GamingDemo.Adapter;
using GamingDemo.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamingDemo.Concrete
{
    public class GamerCheckManager : IGamerCheckService
    {
        IGamerCheckService _gamerCheckService;
        public bool CheckGamerIfRealPerson(Gamer gamer)
        {
            
            _gamerCheckService = new MernisServiceAdapter();
            return _gamerCheckService.CheckGamerIfRealPerson(gamer);
        }
    }
}
