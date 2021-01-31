using GameProject.Entities;
using GameProject.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class GameManager : IGameService
    {
        public void Purchase(Game game, Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " purchased " + game.Name);
        }
    }
}
