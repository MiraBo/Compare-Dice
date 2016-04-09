using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4LinQ
{
    public class Class1  
    {
        public int die1 { get; set; }
        public int die2 { get; set; }


        public static List<Class1> GetDice()
        {
            List<Class1> listDice = new List<Class1>
            {
            new Class1
            {
                die1 = 0,
                die2 = 0,
            
            },
        };
            return listDice;
        }
    }
}
