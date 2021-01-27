using GameApp.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameApp.Abstract
{
    public interface ICompaingService
    {
        void GameCampaingAdd(Campaing campaing);
        void GameCampaingUpdate(Campaing campaing);
        void GameCampaingDelete(Campaing campaing);
    }
}
