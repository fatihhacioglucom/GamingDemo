using GamingDemo.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamingDemo.Abstract
{
    public interface IOrderService
    {
        void Sales(Game game, Gamer gamer, Campaing campaing);
    }
}
