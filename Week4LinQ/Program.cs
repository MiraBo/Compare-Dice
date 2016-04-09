using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4LinQ
{
    public static class Program
    {
        public static void Main(string[] args)
        {

            var rand = new Random();
            var list1 = RollDice(rand, 20);
            var list2 = RollDice(rand, 20);

            string output = string.Join(" ", list1.Select(x => x.ToString()));
            string output1 = string.Join(" ", list2.Select(x => x.ToString()));

            Console.WriteLine("List 1 : " + output);
            Console.WriteLine("List 2 : " + output1);
            
            var compareRolls = list1.Except(list2);
            Console.WriteLine("Difference between Rolls : " + string.Join("; ", compareRolls.Select(x => x.ToString())));

            Console.ReadKey();

        }
        
        private static List<int> RollDice(Random random, int length)
        {
            var result = new List<int>();
            for (int i = 0; i < length; i++)
            {
                var roll = random.Next(1, 7);
                result.Add(roll);
            }
            return result;
            }
        }
    
    }