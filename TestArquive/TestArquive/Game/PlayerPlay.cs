namespace TestArquive.Game
{
    public class PlayerPlay
    {
        public static bool Player(int pos1, int pos2)
        {
            if (Logic.arrGame[pos1,pos2] == 0)
            {
                Logic.arrGame[pos1, pos2] = 1;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
