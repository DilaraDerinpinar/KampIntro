using System;
using System.Collections.Generic;
using System.Text;
using GameDemo.Entities;

namespace GameDemo.ProjectServices
{
    interface IGameService
    {
        void AddGame(Game game);
        void DeleteGame(Game game);
        void UpdateGame(Game game);

    }
}
