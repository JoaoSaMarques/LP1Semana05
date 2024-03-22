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

        public int GetNumRooms()
        {
            return _rooms.Length;
        }

        public int GetNumEnemies()
        {
            return _rooms.Count(r => r != null);
        }

        public void SetEnemyInRoom(int roomIndex, Enemy enemy)
        {
            _rooms[roomIndex] = enemy;
        }

        public void PrintEnemies()
        {
            for (int i = 0; i < _rooms.Length; i++)
            {
                if (_rooms[i] != null)
                {
                    Console.WriteLine($"Room {i}: {_rooms[i].GetName()}");
                }
            }
        }
    }
}