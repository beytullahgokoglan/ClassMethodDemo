using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Interface
{
    public interface ISalesService
    {
        public void Sell(Gamer gamer, Game game, Campaign campaign);
    }
}
