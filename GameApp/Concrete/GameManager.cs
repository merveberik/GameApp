using GameApp.Abstract;
using GameApp.Entities;
using GameApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameApp.Concrete
{
    public class GameManager : IGameService
    {
        public void CampaingGame(Game game, Campaing campaing)
        {
            Console.WriteLine(game.Name + " game "+ campaing.CampaingName+" has campain.");
        }

        public void GameSelling(Game game, Player player)
        {
            Console.WriteLine(game.Name+" game " + player.FirstName +" "+ player.LastName + " was sold.");
        }
    }
}
