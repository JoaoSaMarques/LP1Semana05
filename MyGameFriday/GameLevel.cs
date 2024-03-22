using System;
using System.Linq;
using System.Collections.Generic;

namespace MyGameFriday
{
    public class GameLevel
    {
        private Enemy[] _rooms;
        private Difficulty _difficulty;

        public GameLevel(int numRooms, Difficulty difficulty)
        {
            _rooms = new Enemy[numRooms];
            _difficulty = difficulty;
        }

        public Difficulty GetDifficulty()
        {
            return _difficulty;
        }


    }
}