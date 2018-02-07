using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBF_Sample01
{
    public static class Turns
    {
        public static int turn = 1;
    }
    public class Turns_Manager
    {
        public void Turn_show()
        {
            Console.WriteLine("当前回合：{0}", Turns.turn);
        }
        public void Turn_Add()
        {
            Turns.turn = Turns.turn + 1;
        }
        public void Turn_Reset()
        {
            Turns.turn = 1;
        }
    }
}
