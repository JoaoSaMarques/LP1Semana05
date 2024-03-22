using System;
using System.Linq;
using System.Collections.Generic;

namespace MyGameFriday
{
    /// <summary>
    /// Class utilized as a manager for the code
    /// </summary>
    public class GameLevel
    {
        /// <summary>
        /// Array for the number of rooms
        /// </summary>
        private Enemy[] Rooms;
        private Difficulty RoomDifficulty;

        public GameLevel(int numRooms, Difficulty difficulty)
        {
            Rooms = new Enemy[numRooms];
            RoomDifficulty = difficulty;
        }
        /// <summary>
        /// This will attempt to get the difficulty of the room
        /// </summary>
        /// <returns>returns the difficulty gained</returns>
        public Difficulty GetDifficulty()
        {
            return RoomDifficulty;
        }
        /// <summary>
        /// Will attempt to get the number of rooms in the code
        /// </summary>
        /// <returns>it will return the number of rooms</returns>
        public int GetNumRooms()
        {
            return Rooms.Length;
        }

        /// <summary>
        /// Will attempt to get the number of enemies in the code
        /// </summary>
        /// <returns>returns how many enemies in a room at that time</returns>
        public int GetNumEnemies()
        {
            return Rooms.Count(r => r != null);
        }

        /// <summary>
        /// Will attempt to set the enemy in a room in the array
        /// </summary>
        /// <param name="roomIndex">Room array</param>
        /// <param name="enemy">enemy</param>
        public void SetEnemyInRoom(int roomIndex, Enemy enemy)
        {
            Rooms[roomIndex] = enemy;
        }

        /// <summary>
        /// This will show the room's number and the room's name
        /// </summary>
        public void PrintEnemies()
        {
            for (int i = 0; i < Rooms.Length; i++)
            {
                if (Rooms[i] != null)
                {
                    Console.WriteLine($"Room {i}: {Rooms[i].GetName()}");
                }
            }
        }
    }
}