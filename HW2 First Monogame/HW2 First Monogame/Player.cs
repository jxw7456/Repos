using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2_First_Monogame
{
    class Player:GameObject
    {
        int levelScore; //score of current level
        int totalScore; //player's total score since starting the game

        public Player(int levelScore, int totalScore) : base()
        {
            levelScore = 1000;
            totalScore = 5000;
        }
    }
}
