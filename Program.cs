using System;

namespace learnGit
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 6;
           for(int j = 0;j < 4; j++)
            {
                i += 1;
                if (i == 8) break;
            }

            i = 0;
        }
    }
}
