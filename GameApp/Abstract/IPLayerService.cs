using System;
using System.Collections.Generic;
using System.Text;
using GameApp.Entities;

namespace GameApp.Abstract
{
    public interface IPLayerService
    {
        void PlayerSave(Player player);
        void PlayerUpdate(Player player);
        void PlayerDelete(Player player);
    }
}
