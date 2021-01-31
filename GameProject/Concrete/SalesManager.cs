using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Entities;
using GameProject.Interface;

namespace GameProject.Concrete
{
    public class SalesManager : ISalesService
    {
        public void Sell(Gamer gamer, Game game, Campaign campaign)
        {
            double indirim = game.Price * campaign.Discount / 100;
            double price = game.Price - indirim;
            Console.WriteLine(gamer.FirstName + " " + gamer.LastName + " " + game.Name + " adlı oyunu " 
                + campaign.Name + " kampanyasi ile satin aldi " + price + " değerinde ücret ödedi.");

        }
    }
}
