using GameProject.Abstarct;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject.Concrete
{
    public class GameManager : IGameService

    {
        public void Sell(Gamer gamer,Game game,Campaign campaign)
        {
            Console.WriteLine(gamer.FirstName+" "+gamer.LastName+"isimli müşteri"+game.GameName+" "+"isimli oyunu"+" "+
            campaign.CampaignDiscount+" "+"kampanya ücreti ile satın aldı");
        }
    }
}
