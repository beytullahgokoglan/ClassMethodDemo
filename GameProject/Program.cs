using GameProject.Abstract;
using GameProject.Adapters;
using GameProject.Entities;
using System;
using GameProject.Interface;
using GameProject.Concrete;
namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new MernisServiceAdapter());
            GameManager gameManager = new GameManager();
            CampaignManager campaignManager = new CampaignManager();
            Game game1= new Game { Id = 1, Name = "PUBG", Price = 10.5, Stock = 3 };
            Game game2 = new Game { Id = 2, Name = "VALORANT", Price = 20, Stock = 10 };
            Gamer gamer = new Gamer { FirstName = "Engin", LastName = "Demiroğ", TcNo = 28861499108,DateofBirth=1985 };
            Campaign campaign = new Campaign { Id=1,Name="Kodlama.io ",Discount=70};
            SalesManager salesManager = new SalesManager();

            gamerManager.Add(gamer);
            gameManager.Purchase(game2, gamer);
            campaignManager.Add(campaign);
            salesManager.Sell(gamer, game2, campaign);

            
        }
    }
}
