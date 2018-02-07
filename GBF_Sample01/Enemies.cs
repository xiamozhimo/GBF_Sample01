using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBF_Sample01
{
    public class Enemy : Attribute
    {
        public override void say_wAtk()
        {

        }

        public override void say_wDie()
        {

        }
    }

    public class Bahamut : Enemy
    {
        public override void say_wAtk()
        {
            Console.WriteLine("{0}: \"颤抖吧, 凡人。\"\r\n", this.name);
        }

        public override void say_wDie()
        {
            Console.WriteLine("{0}: ......");
        }
        public Bahamut()
        {
            name = "Peng仙";
            hp_Max = 1000000;
            hp = hp_Max;
            ca = 0;
            atk = 999999;
            _atk = atk;
            def = 10;
            _def = def;
            critical_Posibility = 0;
            critical_Rate = 0;
            isAlive = true;
            ca_max = 8;
            default_CA_rate = 1;
            da_rate = 0.3;
            ta_rate = 1;

         }
    }
}
