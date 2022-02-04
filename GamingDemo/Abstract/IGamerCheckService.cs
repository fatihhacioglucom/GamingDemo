using GamingDemo.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamingDemo.Abstract
{
    public interface IGamerCheckService
    {
        bool CheckGamerIfRealPerson(Gamer gamer);
    }
}
