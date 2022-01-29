namespace TestArquive.Game
{
    public class Reset
    {
        public static void ResetArray()
        {
            for (int j = 0; j < 3; j++)
            {
                for (int i = 0; i < 3; i++)
                {
                    Logic.arrGame[j, i] = 0;
                }
            }
        }
    }
}
