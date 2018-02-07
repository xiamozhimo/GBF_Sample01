using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBF_Sample01
{
    public static class BattleField
    {
        public static List<Enemy> bf_E = new List<Enemy>();
        public static List<Charactor> bf_C = new List<Charactor>();
        public class Ba_Initialize
        {
            public Ba_Initialize()
            {
                Chapter ch = new Chapter_1();
                bf_E = ch.enemy_List;
                bf_C = ch.charactor_List;
            }
        }
    }
}


        

