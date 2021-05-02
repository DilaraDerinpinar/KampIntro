using System;
using System.Collections.Generic;
using System.Text;
using GameDemo.Entities;
using GameDemo.ProjectServices;

namespace GameDemo.Concrete
{
    class GameManager:IGameService
    {
        public void AddGame(Game game)
        {
            Console.WriteLine($"{game.GameName} oyunu eklendi. {game.GameID} idsini aratarak veya adını girerek erişebilirsiniz");
        }

        public void DeleteGame(Game game)
        {
            Console.WriteLine($"{game.GameID} id si olan oyun silindi..");
        }

        public void UpdateGame(Game game)
        {
            Console.WriteLine($"{game.GameName} oyununda güncellemeler var bakmak için hemen tıklayın!");
        }
    }
}
