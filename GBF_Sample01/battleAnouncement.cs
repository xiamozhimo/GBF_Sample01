using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBF_Sample01
{
    public class battleAnouncement
    {
        public void damage_num(int dmg)
        {
            Console.WriteLine(" HP-{0}", dmg);
        }
        public void no_Effect()
        {
            Console.WriteLine("No Effect");
        }
        public void buff_on(Buff b)
        {
            switch (b.buff_Type)
            {
                case 0:
                case 1:
                    Console.WriteLine("ATK UP");
                    break;
                case 2:
                case 3:
                    Console.WriteLine("DEF UP");
                    break;
            }
        }
        public void casting_Skill(Attribute a, Skl s)
        {
            Console.WriteLine("{0} 施放了 {1}", a.name, s.skl_Name);
        }
    }  
}
