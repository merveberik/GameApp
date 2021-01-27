using System;
using System.Collections.Generic;
using System.Text;
using GameApp.Entities;

namespace GameApp.Abstract
{
    public interface IGameService
    {
        void CampaingGame(Game game, Campaing campaing);
        void GameSelling(Game game, Player player);

    }
}
