using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBF_Sample01
{
    public class Charactor : Attribute
    {
        public override void say_wAtk()
        {

        }

        public override void say_wDie()
        {

        }


    }
    public class Vira : Charactor
    {
        public override void say_wAtk()
        {
            Console.WriteLine("{0}: \"我小{0}今天就要砍死你\"\r\n", this.name);
        }

        public override void say_wDie()
        {
            Console.WriteLine("{0} :\"peng仙！是peng仙！啊我死了！\"", this.name);
        }
        public Vira()
        {
            name = "Vira";
            hp_Max = 11367;
            hp = hp_Max;
            ca = 30;
            atk = 3500;
            def = 10;
            _atk = atk;
            _def = def;
            critical_Posibility = 0;
            critical_Rate = 0;
            isAlive = true;
            ca_max = 100;
            default_CA_rate = 1;
            da_rate = 0.55;
            ta_rate = 0.55;
            Layer_Rise_II lr = new Layer_Rise_II();
            lr.who_casting = this;
            lr.casting_target.Add(this);
            this.skill.Add(lr);
        }
    }
    //public class TestCh : Charactor
    //{
    //    public TestCh()
    //    {
    //        name = "TestRbt";
    //        hp_Max = 11367;
    //        hp = hp_Max;
    //        ca = 30;
    //        atk = 3500;
    //        _atk = atk;
    //        def = 10;
    //        critical_Posibility = 0;
    //        critical_Rate = 0;
    //        isAlive = true;
    //        ca_max = 100;
    //        default_CA_rate = 1;
    //        da_rate = 0.55;
    //        ta_rate = 0.55;
    //        side = (int)sidelist.Ally;
    //        position = 1;
    //    }
    //}
}
