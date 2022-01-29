using System;

namespace TestArquive.Game
{
    public class BotPlay
    {
        public enum Play
        {
            player = 1,
            bot = 2,
            empty = 0
        }
    public static void BotTurn()
        {
            if (
                Logic.arrGame[0, 0] != (int)Play.empty &&
                Logic.arrGame[0, 1] != (int)Play.empty &&
                Logic.arrGame[0, 2] != (int)Play.empty &&
                Logic.arrGame[1, 0] != (int)Play.empty &&
                Logic.arrGame[1, 1] != (int)Play.empty &&
                Logic.arrGame[1, 2] != (int)Play.empty &&
                Logic.arrGame[2, 0] != (int)Play.empty &&
                Logic.arrGame[2, 1] != (int)Play.empty &&
                Logic.arrGame[2, 2] != (int)Play.empty)
            {
                return;
            }

            //primeira linha
            if (Logic.arrGame[0, 0] == (int)Play.bot && Logic.arrGame[0, 1] == (int)Play.bot || Logic.arrGame[0, 0] == (int)Play.player && Logic.arrGame[0, 1] == (int)Play.player)
            {
                if (Logic.arrGame[0, 2] == (int)Play.empty)
                {
                    Logic.arrGame[0, 2] = (int)Play.bot;
                    return;
                }
            }

            if (Logic.arrGame[0, 2] == (int)Play.bot && Logic.arrGame[0, 1] == (int)Play.bot || Logic.arrGame[0, 2] == (int)Play.player && Logic.arrGame[0, 1] == (int)Play.player)
            {
                if (Logic.arrGame[0, 0] == (int)Play.empty)
                {
                    Logic.arrGame[0, 0] = (int)Play.bot;
                    return;
                }
            }

            if (Logic.arrGame[0, 0] == (int)Play.bot && Logic.arrGame[0, 2] == (int)Play.bot || Logic.arrGame[0, 0] == (int)Play.player && Logic.arrGame[0, 2] == (int)Play.player)
            {
                if (Logic.arrGame[0, 1] == (int)Play.empty)
                {
                    Logic.arrGame[0, 1] = (int)Play.bot;
                    return;
                }
            }
            //segunda linha
            if (Logic.arrGame[1, 0] == (int)Play.bot && Logic.arrGame[1, 1] == (int)Play.bot || Logic.arrGame[1, 0] == (int)Play.player && Logic.arrGame[1, 1] == (int)Play.player)
            {
                if (Logic.arrGame[1, 2] == (int)Play.empty)
                {
                    Logic.arrGame[1, 2] = (int)Play.bot;
                    return;
                }
            }

            if (Logic.arrGame[1, 1] == (int)Play.bot && Logic.arrGame[1, 2] == (int)Play.bot || Logic.arrGame[1, 1] == (int)Play.player && Logic.arrGame[1, 2] == (int)Play.player)
            {
                if (Logic.arrGame[1, 0] == (int)Play.empty)
                {
                    Logic.arrGame[1, 0] = (int)Play.bot;
                    return;
                }
            }

            if (Logic.arrGame[1, 0] == (int)Play.bot && Logic.arrGame[1, 2] == (int)Play.bot || Logic.arrGame[1, 0] == (int)Play.player && Logic.arrGame[1, 2] == (int)Play.player)
            {
                if (Logic.arrGame[1, 1] == (int)Play.empty)
                {
                    Logic.arrGame[1, 1] = (int)Play.bot;
                    return;
                }
            }
            //terceira linha
            if (Logic.arrGame[2, 0] == (int)Play.bot && Logic.arrGame[2, 1] == (int)Play.bot || Logic.arrGame[2, 0] == (int)Play.player && Logic.arrGame[2, 1] == (int)Play.player)
            {
                if (Logic.arrGame[2, 2] == (int)Play.empty)
                {
                    Logic.arrGame[2, 2] = (int)Play.bot;
                    return;
                }
            }

            if (Logic.arrGame[2, 1] == (int)Play.bot && Logic.arrGame[2, 2] == (int)Play.bot || Logic.arrGame[2, 1] == (int)Play.player && Logic.arrGame[2, 2] == (int)Play.player)
            {
                if (Logic.arrGame[2, 0] == (int)Play.empty)
                {
                    Logic.arrGame[2, 0] = (int)Play.bot;
                    return;
                }
            }

            if (Logic.arrGame[2, 0] == (int)Play.bot && Logic.arrGame[2, 2] == (int)Play.bot || Logic.arrGame[2, 0] == (int)Play.player && Logic.arrGame[2, 2] == (int)Play.player)
            {
                if (Logic.arrGame[2, 1] == (int)Play.empty)
                {
                    Logic.arrGame[2, 1] = (int)Play.bot;
                    return;
                }
            }
            //primeira coluna
            if (Logic.arrGame[0, 0] == (int)Play.bot && Logic.arrGame[1, 0] == (int)Play.bot || Logic.arrGame[0, 0] == (int)Play.player && Logic.arrGame[1, 0] == (int)Play.player)
            {
                if (Logic.arrGame[2, 0] == (int)Play.empty)
                {
                    Logic.arrGame[2, 0] = (int)Play.bot;
                    return;
                }
            }

            if (Logic.arrGame[1, 0] == (int)Play.bot && Logic.arrGame[2, 0] == (int)Play.bot || Logic.arrGame[1, 0] == (int)Play.player && Logic.arrGame[2, 0] == (int)Play.player)
            {
                if (Logic.arrGame[0, 0] == (int)Play.empty)
                {
                    Logic.arrGame[0, 0] = (int)Play.bot;
                    return;
                }
            }

            if (Logic.arrGame[0, 0] == (int)Play.bot && Logic.arrGame[2, 0] == (int)Play.bot || Logic.arrGame[0, 0] == (int)Play.player && Logic.arrGame[2, 0] == (int)Play.player)
            {
                if (Logic.arrGame[1, 0] == (int)Play.empty)
                {
                    Logic.arrGame[1, 0] = (int)Play.bot;
                    return;
                }
            }
            //segunda coluna
            if (Logic.arrGame[0, 1] == (int)Play.bot && Logic.arrGame[1, 1] == (int)Play.bot || Logic.arrGame[0, 1] == (int)Play.player && Logic.arrGame[1, 1] == (int)Play.player)
            {
                if (Logic.arrGame[2, 1] == (int)Play.empty)
                {
                    Logic.arrGame[2, 1] = (int)Play.bot;
                    return;
                }
            }

            if (Logic.arrGame[1, 1] == (int)Play.bot && Logic.arrGame[2, 1] == (int)Play.bot || Logic.arrGame[1, 1] == (int)Play.player && Logic.arrGame[2, 1] == (int)Play.player)
            {
                if (Logic.arrGame[0, 1] == (int)Play.empty)
                {
                    Logic.arrGame[0, 1] = (int)Play.bot;
                    return;
                }
            }

            if (Logic.arrGame[0, 1] == (int)Play.bot && Logic.arrGame[2, 1] == (int)Play.bot || Logic.arrGame[0, 1] == (int)Play.player && Logic.arrGame[2, 1] == (int)Play.player)
            {
                if (Logic.arrGame[1, 1] == (int)Play.empty)
                {
                    Logic.arrGame[1, 1] = (int)Play.bot;
                    return;
                }
            }
            //terceira coluna
            if (Logic.arrGame[0, 2] == (int)Play.bot && Logic.arrGame[1, 2] == (int)Play.bot || Logic.arrGame[0, 2] == (int)Play.player && Logic.arrGame[1, 2] == (int)Play.player)
            {
                if (Logic.arrGame[2, 2] == (int)Play.empty)
                {
                    Logic.arrGame[2, 2] = (int)Play.bot;
                    return;
                }
            }

            if (Logic.arrGame[1, 2] == (int)Play.bot && Logic.arrGame[2, 2] == (int)Play.bot || Logic.arrGame[1, 2] == (int)Play.player && Logic.arrGame[2, 2] == (int)Play.player)
            {
                if (Logic.arrGame[0, 2] == (int)Play.empty)
                {
                    Logic.arrGame[0, 2] = (int)Play.bot;
                    return;
                }
            }

            if (Logic.arrGame[0, 2] == (int)Play.bot && Logic.arrGame[2, 2] == (int)Play.bot || Logic.arrGame[0, 2] == (int)Play.player && Logic.arrGame[2, 2] == (int)Play.player)
            {
                if (Logic.arrGame[1, 2] == (int)Play.empty)
                {
                    Logic.arrGame[1, 2] = (int)Play.bot;
                    return;
                }
            }
            //diagonal direita
            if (Logic.arrGame[0, 0] == (int)Play.bot && Logic.arrGame[1, 1] == (int)Play.bot || Logic.arrGame[0, 0] == (int)Play.player && Logic.arrGame[1, 1] == (int)Play.player)
            {
                if (Logic.arrGame[2, 2] == (int)Play.empty)
                {
                    Logic.arrGame[2, 2] = (int)Play.bot;
                    return;
                }
            }

            if (Logic.arrGame[1, 1] == (int)Play.bot && Logic.arrGame[2, 2] == (int)Play.bot || Logic.arrGame[1, 1] == (int)Play.player && Logic.arrGame[2, 2] == (int)Play.player)
            {
                if (Logic.arrGame[0, 0] == (int)Play.empty)
                {
                    Logic.arrGame[0, 0] = (int)Play.bot;
                    return;
                }
            }

            if (Logic.arrGame[0, 0] == (int)Play.bot && Logic.arrGame[2, 2] == (int)Play.bot || Logic.arrGame[0, 0] == (int)Play.player && Logic.arrGame[2, 2] == (int)Play.player)
            {
                if (Logic.arrGame[1, 1] == (int)Play.empty)
                {
                    Logic.arrGame[1, 1] = (int)Play.bot;
                    return;
                }
            }
            //diagonal esquerda
            if (Logic.arrGame[0, 2] == (int)Play.bot && Logic.arrGame[1, 1] == (int)Play.bot || Logic.arrGame[0, 2] == (int)Play.player && Logic.arrGame[1, 1] == (int)Play.player)
            {
                if (Logic.arrGame[2, 0] == (int)Play.empty)
                {
                    Logic.arrGame[2, 0] = (int)Play.bot;
                    return;
                }
            }

            if (Logic.arrGame[2, 0] == (int)Play.bot && Logic.arrGame[1, 1] == (int)Play.bot || Logic.arrGame[2, 0] == (int)Play.player && Logic.arrGame[1, 1] == (int)Play.player)
            {
                if (Logic.arrGame[0, 2] == (int)Play.empty)
                {
                    Logic.arrGame[0, 2] = (int)Play.bot;
                    return;
                }
            }

            if (Logic.arrGame[0, 2] == (int)Play.bot && Logic.arrGame[2, 0] == (int)Play.bot || Logic.arrGame[0, 2] == (int)Play.player && Logic.arrGame[2, 0] == (int)Play.player)
            {
                if (Logic.arrGame[1, 1] == (int)Play.empty)
                {
                    Logic.arrGame[1, 1] = (int)Play.bot;
                    return;
                }
            }

            Random random = new Random();
            bool sair = false;
            if (Logic.winner == 0)
            {
                while (sair == false)
                {
                    int pos1 = random.Next(0, 3);
                    int pos2 = random.Next(0, 3);
                    if (Logic.arrGame[pos1, pos2] == 0)
                    {
                        Logic.arrGame[pos1, pos2] = (int)Play.bot;
                        sair = true;
                    }
                }
            }
        }
    }
}
