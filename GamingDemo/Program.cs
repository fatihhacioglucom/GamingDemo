using GamingDemo.Concrete;
using GamingDemo.Entity;
using System;

namespace GamingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer1 = new Gamer();
            gamer1.Id = 1;
            gamer1.FirstName = "Fatih";
            gamer1.LastName = "Hacıoğlu";
            gamer1.DateOfBirth = new DateTime(1990, 1, 1);
            gamer1.NationalityId = "1234567890";

            Gamer gamer2 = new Gamer();
            gamer2.Id = 2;
            gamer2.FirstName = "Buse";
            gamer2.LastName = "Hacıoğlu";
            gamer2.DateOfBirth = new DateTime(1992, 1, 1);
            gamer2.NationalityId = "0987654321";

            GamerManager gamerManager = new GamerManager(new GamerCheckManager());
            gamerManager.Add(gamer2);

            Game game1 = new Game();
            game1.Id = 1;
            game1.GameName = "Red Dead Redamption 2";
            game1.UnitPrice = 299;
            game1.DiscountedPrice = 149.50;

            Game game2 = new Game();
            game2.Id = 2;
            game2.GameName = "Cyberpunk 2077";
            game2.UnitPrice = 249;
            game2.DiscountedPrice = 124.50;

            Campaing campaing1 = new Campaing();
            campaing1.Id = 1;
            campaing1.CapaingName = "Sepette %50 indirim";

            CampaingManager campaingManager = new CampaingManager();
            campaingManager.Add(campaing1);

            OrderManager orderManager = new OrderManager();
            orderManager.Sales(game1, gamer1, campaing1);
        }
    }
}
