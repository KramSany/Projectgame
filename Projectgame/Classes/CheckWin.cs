using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projectgame.Classes
{
    class TicTacToe
    {
        public TicTacToe()
        {
            int _stepPlayer = 0;
            int[,] _fieldMap = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    _fieldMap[i, j] = 2;
                }
            }
            FieldMap = _fieldMap;
            StepPlayer = _stepPlayer;
        }
        public int[,] FieldMap { get; set; }
        public int StepPlayer { get; set; }

        public bool CheckPosition(int row, int column, bool firstPlayer)
        {
            if (FieldMap[row, column] != 2) return false;
            else if (firstPlayer) FieldMap[row, column] = 1;
            else FieldMap[row, column] = 0;
            return true;
        }
        public int WinPositions()
        {
            StepPlayer++;
            int winnerPlayer = 3;
            if (FieldMap[0, 0] == 1 && FieldMap[0, 1] == 1 && FieldMap[0, 2] == 1)
            {
                winnerPlayer = 1;
                
                return winnerPlayer;
            }
            if (FieldMap[1, 0] == 1 && FieldMap[1, 1] == 1 && FieldMap[1, 2] == 1)
            {
                
                winnerPlayer = 1;
                return winnerPlayer;
            }
                
            if (FieldMap[2, 0] == 1 && FieldMap[2, 1] == 1 && FieldMap[2, 2] == 1)
            {
                
                winnerPlayer = 1;
                return winnerPlayer;
            }
            if (FieldMap[0, 0] == 1 && FieldMap[1, 0] == 1 && FieldMap[2, 0] == 1)
            {
                
                winnerPlayer = 1;
                return winnerPlayer;
            }
            if (FieldMap[0, 1] == 1 && FieldMap[1, 1] == 1 && FieldMap[2, 1] == 1)
            {
                
                winnerPlayer = 1;
                return winnerPlayer;
            }
            if (FieldMap[0, 2] == 1 && FieldMap[1, 2] == 1 && FieldMap[2, 2] == 1)
            {
                
                winnerPlayer = 1;
                return winnerPlayer;
            }
            if (FieldMap[0, 0] == 1 && FieldMap[1, 1] == 1 && FieldMap[2, 2] == 1)
            {
                
                winnerPlayer = 1;
                return winnerPlayer;
            }
            if (FieldMap[2, 0] == 1 && FieldMap[1, 1] == 1 && FieldMap[0, 2] == 1)
            {
                
                winnerPlayer = 1;
                return winnerPlayer;
            }

            if (FieldMap[0, 0] == 0 && FieldMap[0, 1] == 0 && FieldMap[0, 2] == 0)
            {
                
                winnerPlayer = 0;
                return winnerPlayer;
            }
            if (FieldMap[1, 0] == 0 && FieldMap[1, 1] == 0 && FieldMap[1, 2] == 0)
            {
                
                winnerPlayer = 0;
                return winnerPlayer;
            }
            if (FieldMap[2, 0] == 0 && FieldMap[2, 1] == 0 && FieldMap[2, 2] == 0)
            {
                
                winnerPlayer = 0;
                return winnerPlayer;
            }
            if (FieldMap[0, 0] == 0 && FieldMap[1, 0] == 0 && FieldMap[2, 0] == 0)
            {
                
                winnerPlayer = 0;
                return winnerPlayer;
            }
            if (FieldMap[0, 1] == 0 && FieldMap[1, 1] == 0 && FieldMap[2, 1] == 0)
            {
                
                winnerPlayer = 0;
                return winnerPlayer;
            }
            if (FieldMap[0, 2] == 0 && FieldMap[1, 2] == 0 && FieldMap[2, 2] == 0)
            {
                
                winnerPlayer = 0;
                return winnerPlayer;
            }
            if (FieldMap[0, 0] == 0 && FieldMap[1, 1] == 0 && FieldMap[2, 2] == 0)
            {
                
                winnerPlayer = 0;
                return winnerPlayer;
            }
            if (FieldMap[2, 0] == 0 && FieldMap[1, 1] == 0 && FieldMap[0, 2] == 0)
            {
                
                winnerPlayer = 0;
                return winnerPlayer;
            }
            if (StepPlayer == 27) winnerPlayer = 2;
            return winnerPlayer;
        }
        public void ClearField()
        {
            FieldMap = new int[0,0];
        }
    }
}
