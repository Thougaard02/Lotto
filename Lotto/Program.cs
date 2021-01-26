using System;

namespace Lotto
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] winnerTicket = new int[6];
            int[] userCoupon = new int[7] { 1, 2, 3, 4, 5, 8, 12 };
            int macthingNumbers = 0;

            Random r = new Random(Guid.NewGuid().GetHashCode());

            Console.WriteLine("Winning lotto Coupon");
            for (int i = 0; i < winnerTicket.Length; i++)
            {
                winnerTicket[i] = r.Next(1, 20);
                Console.WriteLine(i + 1 + " " + winnerTicket[i]);
            }

            for (int i = 0; i < winnerTicket.Length; i++)
            {
                foreach (int num in userCoupon)
                {
                    if (winnerTicket[i] == num)
                    {
                        macthingNumbers++;
                        break;
                    }
                }
            }
            checkWin(macthingNumbers);
            Console.ReadKey();
        }

        static void checkWin(int macthingNumbers)
        {
            switch (macthingNumbers)
            {
                case 0:
                    Console.WriteLine("Not today you won 0 kr");
                    break;
                case 1:
                    Console.WriteLine("You won 10 kr!");
                    break;
                case 2:
                    Console.WriteLine("You won 20 kr!");
                    break;
                case 3:
                    Console.WriteLine("You won 40kr!");
                    break;
                case 4:
                    Console.WriteLine("You won 80 kr!");
                    break;
                case 5:
                    Console.WriteLine("You won 160 kr!");
                    break;
                case 6:
                    Console.WriteLine("You won 320 kr!");
                    break;
                case 7:
                    Console.WriteLine("You won 640 kr!");
                    break;
            }
        }
    }
}
