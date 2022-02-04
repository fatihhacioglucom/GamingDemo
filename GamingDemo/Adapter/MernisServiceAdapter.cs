using GamingDemo.Abstract;
using GamingDemo.Entity;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamingDemo.Adapter
{
    public class MernisServiceAdapter : IGamerCheckService
    {
        public bool CheckGamerIfRealPerson(Gamer gamer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(Convert.ToInt64(gamer.NationalityId), gamer.FirstName.ToUpper(), gamer.LastName.ToUpper(), gamer.DateOfBirth.Year).Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
