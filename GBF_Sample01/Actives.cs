using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBF_Sample01
{
    public class Atk : IAtk
    {
        public virtual void attack(Attribute a, Attribute b)
        {
            Flow_Objects flo = new Flow_Objects();
            battleAnouncement ba = new battleAnouncement();
            double critical = flo.critical(a,flo.isCrit_Checker(a));
            int attackTimes = flo.mutiAtkTimes(a);
            if (a.isAlive == true)
            {
                Console.Write("总计攻击{0}次\r\n", attackTimes);
                for (int i = 0; (i < attackTimes) && (b.isAlive == true); i++)
                {
                    
                    double damage_Float = flo.randFloat();
                    int dmg = (int)(a._atk * damage_Float * critical / b._def);
                    b.hp = b.hp - dmg;
                    Console.Write("第{0}刀：", i + 1);
                    Console.Write("{0}", b.name);
                    ba.damage_num(dmg);
                    flo.dead_Checker(a);
                    flo.dead_Checker(b);
                }
                flo.CA_Increase(a, attackTimes);
                Console.Write("\r\n");
            }
        }
    }
}
