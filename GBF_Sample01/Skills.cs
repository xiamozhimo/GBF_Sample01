using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBF_Sample01
{
    public class Atk_Skl : Skl
    {
        public override void casting()
        {
            throw new NotImplementedException();
        }
    }
    public abstract class Buff_Skl : Skl
    {

    }

    public class Layer_Rise_II : Buff_Skl
    {
        
        public override void casting()
        {

            if (available_On_Turn<=Turns.turn)
            {

                battleAnouncement ba = new battleAnouncement();
                Vira_SKL1_atk_single_buff aS = new Vira_SKL1_atk_single_buff();
                Vira_SKL1_def_single_buff dS = new Vira_SKL1_def_single_buff();
                Vira_variable_buff_Test VT = new Vira_variable_buff_Test();

                ba.casting_Skill(who_casting, this);
                foreach (Attribute tar in casting_target)
                {
                    aS.buff_on(tar);
                    dS.buff_on(tar);
                    VT.buff_on(tar);
                    tar.buff_reCalc();
                }
                available_On_Turn = Turns.turn + cool_Down;
            }
            else
            {
                Console.WriteLine("技能{0}冷却中，剩余{1}回合可用", skl_Name, available_On_Turn - Turns.turn);
            }
        }
        public Layer_Rise_II()
        {
            skl_Name = this.GetType().Name;
            cool_Down = 6;
            available_On_Turn = 0;
        }
    }
}
