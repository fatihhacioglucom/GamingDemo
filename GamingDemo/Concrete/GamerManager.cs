using GamingDemo.Abstract;
using GamingDemo.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamingDemo.Concrete
{
    public class GamerManager : IGamerService
    {
        IGamerCheckService _gamerCheckService;

        public GamerManager(IGamerCheckService gamerCheckService)
        {
            _gamerCheckService = gamerCheckService;
        }

        public void Add(Gamer gamer)
        {
            if (_gamerCheckService.CheckGamerIfRealPerson(gamer) == true)
            {
                Console.WriteLine("Tebrikler ! Yeni oyuncu başarı ile eklendi : " + gamer.FirstName + " " + gamer.LastName);
            }
            else
            {
                Console.WriteLine("Mernis sistemi ile kişi bilgileri eşleşmedi. Kayıt başarısız.");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Tebrikler ! " + gamer.FirstName + " " + gamer.LastName + " isimli oyuncu başarı ile silindi.");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Tebrikler ! Oyuncu bilgileri başarı ile güncellendi : " + gamer.FirstName + " " + gamer.LastName);
        }
    }
}
