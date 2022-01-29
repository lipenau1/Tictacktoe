namespace TestArquive.Game
{
    public class Logic
    {
        public static int[,] arrGame = new int[3, 3];
        public static int winner = 0;
            public static void CheckBoard()
            {
                if (
                  arrGame[0,0] == arrGame[0,1] &&
                  arrGame[0,1] == arrGame[0,2] &&
                  arrGame[0,0] != 0 && arrGame[0,1] != 0 && arrGame[0,2] != 0
                  )
                {
                    if (arrGame[0,0] == 1)
                    {
                    winner = 1;
                    }
                    else if (arrGame[0,0] == 2)
                    {
                    winner = 2;
                    }
                }
                else if (
                arrGame[0,0] == arrGame[1,0] &&
                arrGame[1,0] == arrGame[2,0] &&
                arrGame[0, 0] != 0 && arrGame[1,0] != 0 && arrGame[2, 0] != 0
                )
                {
                    if (arrGame[0,0] == 1)
                    {
                    winner = 1;
                    }
                    else if (arrGame[0,0] == 2)
                    {
                    winner = 2;
                    }
                }
                else if (
                arrGame[0,0] == arrGame[1,1] &&
                arrGame[1,1] == arrGame[2,2] &&
                arrGame[0, 0] != 0 && arrGame[1, 1] != 0 && arrGame[2, 2] != 0
                )
                {
                    if (arrGame[0,0] == 1)
                    {
                    winner = 1;
                    }
                    else if (arrGame[0,0] == 2)
                    {
                    winner = 2;
                    }
                }
                else if (
                arrGame[1,0] == arrGame[1,1] &&
                arrGame[1,1] == arrGame[1,2] &&
                arrGame[1, 0] != 0 && arrGame[1, 1] != 0 && arrGame[1, 2] != 0
                )
                {
                    if (arrGame[1,0] == 1)
                    {
                    winner = 1;
                    }
                    else if (arrGame[1,0] == 2)
                    {
                    winner = 2;
                    }
                }
                else if (
                arrGame[2,0] == arrGame[2,1] &&
                arrGame[2,1] == arrGame[2,2] &&
                arrGame[2, 0] != 0 && arrGame[2, 1] != 0 && arrGame[2, 2] != 0
                )
                {
                    if (arrGame[2,0] == 1)
                    {
                    winner = 1;
                    }
                    else if (arrGame[2,0] == 2)
                    {
                    winner = 2;
                    }
                }
                else if (
                arrGame[0,1] == arrGame[1,1] &&
                arrGame[1,1] == arrGame[2,1] &&
                arrGame[0, 1] != 0 && arrGame[1, 1] != 0 && arrGame[2, 1] != 0
                )
                {
                    if (arrGame[0,1] == 1)
                    {
                    winner = 1;
                    }
                    else if (arrGame[0,1] == 2)
                    {
                    winner = 2;
                    }
                }
                else if (
                arrGame[0,2] == arrGame[1,2] &&
                arrGame[1,2] == arrGame[2,2] &&
                arrGame[0, 2] != 0 && arrGame[1, 2] != 0 && arrGame[2, 2] != 0
                )
                {
                    if (arrGame[0,2] == 1)
                    {
                    winner = 1;
                    }
                    else if (arrGame[0,2] == 2)
                    {
                    winner = 2;
                    }
                }
                else if (
                arrGame[0,2] == arrGame[1,1] &&
                arrGame[1,1] == arrGame[2,0] &&
                arrGame[0, 2] != 0 && arrGame[1, 1] != 0 && arrGame[2, 0] != 0
                )
                {
                    if (arrGame[0,2] == 1)
                    {
                    winner = 1;
                    }
                    else if (arrGame[0,2] == 2)
                    {
                    winner = 2;
                    }
                }
                else if (
                arrGame[0,0] != 0 &&
                arrGame[0,1] != 0 &&
                arrGame[0,2] != 0 &&
                arrGame[1,0] != 0 &&
                arrGame[1,1] != 0 &&
                arrGame[1,2] != 0 &&
                arrGame[2,0] != 0 &&
                arrGame[2,1] != 0 &&
                arrGame[2,2] != 0
                )
                {
                winner = 3;
                }           
            }
        }
    }
