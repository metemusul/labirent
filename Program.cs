using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev3_labirent_New
{
    class Labirent
    {
        public int step = 0;

		
        public void findWay(int[,] lab)
		{
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("labirent de yol bulma işlemi başlıyor  !!");
			int move = lab[0,0];

            for (int i = 0; i < lab.GetLength(0); i++)
			{
                for (int j = 0; j < lab.GetLength(1) ; j++)
                {
                
                    try
                    {
                        if (lab[i, j + 1] == 0 && move != lab[i, j])
                        {
                            move = lab[i, j + 1];
                            step++;
                        }
                        else if (lab[i + 1, j] == 0 && move != lab[i, j])
                        {
                            move = lab[i + 1, j];
                            step++;
                        }
                        else if (lab[i - 1, j] == 0 && move != lab[i, j])
                        {
                            move = lab[i - 1, j];
                            step++;
                        }
                        else if (lab[i, j - 1] == 0 && move != lab[i, j])
                        {
                            move = lab[i, j - 1];
                            step++;
                        }
                    }
                    catch (IndexOutOfRangeException e)
                    {
                        
                        // Hata görmezden gel, bir şey yapma
                    }


                }
				
			}
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("yol bulma işlemi tamamlandı \nbu işlem verilen matris için {0} adımda gerçekleşti  ", step);
		}

		public void showWay(int[,] lab)
		{
			for (int i = 0; i < lab.GetLength(0); i++)
			{
				for (int j = 0; j < lab.GetLength(1); j++)
				{
					if (lab[i, j] == 0)
					{
						Console.ForegroundColor = ConsoleColor.Red;
						Console.Write(lab[i, j]);
					}
					else
					{
						Console.ResetColor();
						Console.Write(lab[i, j]);
					}
				}
				Console.WriteLine();
			}
		}
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] labMatris =
            {
         {0,0,1,1,1,1,1,1 },
         {1,0,1,1,1,1,1,1 },
         {1,0,1,1,0,0,0,1 },
         {0,0,1,0,0,1,0,1 },
         {0,1,1,0,1,1,0,1 },
         {0,0,0,0,1,1,0,0 },
         {1,1,1,1,1,1,1,0 },
         {1,1,1,1,1,1,1,0 }

     };
            Labirent labirent = new Labirent();

            labirent.showWay(labMatris);
            labirent.findWay(labMatris);

            Console.ReadLine();
        }
    }
}
