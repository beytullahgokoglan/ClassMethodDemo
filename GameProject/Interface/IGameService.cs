using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Interface
{
    public interface IGameService
    {
        void Purchase(Game game, Gamer gamer);
    }
}
