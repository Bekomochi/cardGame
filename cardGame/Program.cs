using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cardGame
{
    internal class Program
    {
        public static int[] cardNumerical;
       

        static void Main(string[] args)
        {
            string cardName;
            int cardNum;
            
            for (int i = 0; i < 4; i++) 
            {
                Console.Write("{0}つめのカードの数値を入力してください>", i + 1,cardName=Console.ReadLine());
                int.TryParse(Console.ReadLine(), out cardNum);
                Console.ReadLine();

                cardNumerical[i] = cardNum;

                Console.WriteLine("{0}つめの数値は{1}です", cardNumerical[i+1], cardNum);
                Console.ReadLine();
            }
        }
    }
}
