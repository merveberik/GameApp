using GameApp.Abstract;
using System;
//using System.Collections.Generic;
//using System.Text;

namespace GameApp.Entities
{
    public class Campaing: IEntity 
    {
        public int Id { get; set; }
        public string CampaingName { get; set; }
        public object GameCampaingAdd { get; internal set; }

    }
}
