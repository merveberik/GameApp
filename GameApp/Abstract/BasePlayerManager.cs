using System;
using System.Collections.Generic;
using System.Text;

namespace GameApp.Abstract
{
    public abstract class BasePlayerManager : IPLayerService
    {
        public void PlayerDelete(Player player)
        {
            Console.WriteLine("Player was deleted: " + player.FirstName + " " + player.LastName);
        }

        public virtual void PlayerSave(Player player)
        {
            Console.WriteLine("Player was added: " + player.FirstName + " " + player.LastName);
        }

        public void PlayerUpdate(Player player)
        {
            Console.WriteLine("Player was updated: " + player.FirstName + " " + player.LastName);
        }
    }
}
