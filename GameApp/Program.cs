using GameApp.Concrete;
using GameApp.Entities;
using System;

namespace GameApp
{
    class Program
    {
        static void Main(string[] args)
        {
            PlayerManager playerManager = new PlayerManager();
            Player player = new Player { DateOfBirth = new DateTime(1996, 03, 20), FirstName = "Merve", LastName = "Berik", NationalityId = "12345687" };
            playerManager.PlayerSave(player);
            playerManager.PlayerUpdate(player);
            Player player2 = new Player { DateOfBirth = new DateTime(1998, 08, 15), FirstName = "Ayşe", LastName = "Öz", NationalityId = "45678912" };
            playerManager.PlayerDelete(player2);

            CampaingManager campaingManager = new CampaingManager();
            Campaing campaing1 = new Campaing { CampaingName = "Student Campaing", Id = 25 };
            campaingManager.GameCampaingAdd(campaing1);
            Campaing campaing2 = new Campaing { CampaingName = "Summar Campaing", Id = 25 };
            campaingManager.GameCampaingDelete(campaing2);


            GameManager gameManager = new GameManager();
            Game game1 = new Game { Name = "Snake" };
            gameManager.GameSelling(game1, player);
            Game game2 = new Game { Name = "Zuma" };
            gameManager.CampaingGame(game1, campaing1);
            Console.ReadLine();
        }
    }
}
