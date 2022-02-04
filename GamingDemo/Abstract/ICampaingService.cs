using GamingDemo.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamingDemo.Abstract
{
    public interface ICampaingService
    {
        void Add(Campaing campaing);
        void Update(Campaing campaing);
        void Delete(Campaing campaing);
    }
}
