using System;
using System.Collections.Generic;
using System.Text;
using GameDemo.Entities;
using GameDemo.ProjectServices;

namespace GameDemo.ProjectManagementService
{
    class GameManager:IGameService
    {
        public void AddGame(Game game)
        {
            Console.WriteLine($"{game.gameName} oyunu eklendi. {game.gameID} idsini aratarak veya adını girerek erişebilirsiniz");
        }

        public void DeleteGame(Game game)
        {
            Console.WriteLine($"{game.gameID} id si olan oyun silindi..");
        }

        public void UpdateGame(Game game)
        {
            Console.WriteLine($"{game.gameName} oyununda güncellemeler var bakmak için hemen tıklayın!");
        }
    }
}
