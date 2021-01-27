using GameApp.Abstract;
using GameApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameApp.Concrete
{
    public class CampaingManager : ICompaingService
    {
        public void GameCampaingAdd(Campaing campaing)
        {
            Console.WriteLine("Game campaing added: "+ campaing.CampaingName);
        }

        public void GameCampaingDelete(Campaing campaing)
        {
            Console.WriteLine("Game campaing deleted: " + campaing.CampaingName);
        }

        public void GameCampaingUpdate(Campaing campaing)
        {
            Console.WriteLine("Game campaing updated: " + campaing.CampaingName);
        }


    }
}
