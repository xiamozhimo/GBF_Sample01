using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBF_Sample01
{
    public class Buff
    {
        public String buff_name;

        public string buff_or_Db;

        public enum status_List
        {
            buff = 0,
            debuff = 1
        }

        public int start_at_Turn;
        public int affect_turns;
        public int end_at_trun;

        public double _atk_SingleSide_Rate; //1 负值为DB，正值为BUFF，下同
        public double _atk_DoubleSide_Rate; //2

        public double _def_SingleSide_Rate; //3
        public double _def_DoubleSide_Rate; //4

        public double _da_SingleSide_Rate; //5
        public double _da_DoubleSide_Rate; //6


        public double _ta_SingleSide_Rate; //7
        public double _ta_DoubleSide_Rate; //8

        public double _ca_SingleSide_Rate; //9
        public double _ca_DoubleSide_Rate; //10

        public bool revive;                //100
        public bool isSklSealed;           //101
        public bool isCaSealed;            //102
        public bool isAtkSealed;           //103

        public int buff_Type;
        public virtual void buff_refresh()
        {

        }
        public void buff_on(Attribute a)
        {
            battleAnouncement ba = new battleAnouncement();
            int attri_Index = a.buff.FindIndex(x => x.buff_Type.Equals(this.buff_Type));
            if (attri_Index == -1)
            {
                a.buff.Add(this);
            }
            else if (this.buff_Type >= 100)
            {
                a.buff[this.buff_Type] = this;

            }
            else if (this.buff_Type >= 0 && this.buff_Type <= 99)
            {
                switch (this.buff_Type)
                {
                    case 1:
                        if (this._atk_SingleSide_Rate >= a.buff[attri_Index]._atk_SingleSide_Rate)//_atk_SingleSide_Rate
                        {
                            a.buff[attri_Index] = this;
                        }
                        else
                        {
                            ba.no_Effect();
                        }
                        break;

                    case 2:
                        if (this._atk_DoubleSide_Rate >= a.buff[attri_Index]._atk_DoubleSide_Rate)//_atk_DoubleSide_Rate
                        {
                            a.buff[attri_Index] = this;
                        }
                        else
                        {
                            ba.no_Effect();
                        }
                        break;

                    case 3:
                        if (this._def_SingleSide_Rate >= a.buff[attri_Index]._def_SingleSide_Rate)//_def_SingleSide_Rate
                        {
                            a.buff[attri_Index] = this;
                        }
                        else
                        {
                            ba.no_Effect();
                        }
                        break;

                    case 4:
                        if (this._def_DoubleSide_Rate >= a.buff[attri_Index]._def_DoubleSide_Rate)//_def_DoubleSide_Rate
                        {
                            a.buff[attri_Index] = this;
                        }
                        else
                        {
                            ba.no_Effect();
                        }
                        break;

                    case 5:
                        if (this._da_SingleSide_Rate >= a.buff[attri_Index]._da_SingleSide_Rate)//_da_SingleSide_Rate
                        {
                            a.buff[attri_Index] = this;
                        }
                        else
                        {
                            ba.no_Effect();
                        }
                        break;

                    case 6:
                        if (this._da_DoubleSide_Rate >= a.buff[attri_Index]._da_DoubleSide_Rate)//_da_DoubleSide_Rate
                        {
                            a.buff[attri_Index] = this;
                        }
                        else
                        {
                            ba.no_Effect();
                        }
                        break;
                    case 7:
                        if (this._ta_SingleSide_Rate >= a.buff[attri_Index]._ta_SingleSide_Rate)//_ta_SingleSide_Rate
                        {
                            a.buff[attri_Index] = this;
                        }
                        else
                        {
                            ba.no_Effect();
                        }
                        break;

                    case 8:
                        if (this._ta_DoubleSide_Rate >= a.buff[attri_Index]._ta_DoubleSide_Rate)//_ta_DoubleSide_Rate
                        {
                            a.buff[attri_Index] = this;
                        }
                        else
                        {
                            ba.no_Effect();
                        }
                        break;

                    case 9:
                        if (this._ca_SingleSide_Rate >= a.buff[attri_Index]._ca_SingleSide_Rate)//_ca_SingleSide_Rate
                        {
                            a.buff[attri_Index] = this;
                        }
                        else
                        {
                            ba.no_Effect();
                        }
                        break;

                    case 10:
                        if (this._ca_DoubleSide_Rate >= a.buff[attri_Index]._ca_DoubleSide_Rate)// _ca_DoubleSide_Rate
                        {
                            a.buff[attri_Index] = this;
                        }
                        else
                        {
                            ba.no_Effect();
                        }
                        break;
                }
            }
            else
            {
                Console.WriteLine("No Effect");
            }
        }

}    
    public class buff_atk_SingleSide_Rate : Buff
    {
        public buff_atk_SingleSide_Rate()
        {
            buff_name = this.GetType().Name;
            buff_Type = 1;
            buff_or_Db = status_List.buff.ToString();
            start_at_Turn = Turns.turn;
            affect_turns = 1;
            end_at_trun = start_at_Turn + affect_turns;
        }

    }
    public class buff_atk_DoubleSide_Rate : Buff
    {
        public buff_atk_DoubleSide_Rate()
        {
            buff_name = this.GetType().Name;
            buff_Type = 2;
            buff_or_Db = status_List.buff.ToString();
            start_at_Turn = Turns.turn;
            affect_turns = 1;
            end_at_trun = start_at_Turn + affect_turns;
        }
    }
    public class buff_def_SingleSide_Rate : Buff
    {
        public buff_def_SingleSide_Rate()
        {
            buff_name = this.GetType().Name;
            buff_Type = 3;
            buff_or_Db = status_List.buff.ToString();
            start_at_Turn = Turns.turn;
            affect_turns = 1;
            end_at_trun = start_at_Turn + affect_turns;
        }
    }
    public class buff_def_DoubleSide_Rate : Buff
    {
        public buff_def_DoubleSide_Rate()
        {
            buff_name = this.GetType().Name;
            buff_Type = 4;
            buff_or_Db = status_List.buff.ToString();
            start_at_Turn = Turns.turn;
            affect_turns = 1;
            end_at_trun = start_at_Turn + affect_turns;
        }
    }
    public class buff_da_SingleSide_Rate : Buff
    {
        public buff_da_SingleSide_Rate()
        {
            buff_name = this.GetType().Name;
            buff_Type = 5;
            buff_or_Db = status_List.buff.ToString();
            start_at_Turn = Turns.turn;
            affect_turns = 1;
            end_at_trun = start_at_Turn + affect_turns;
        }
    }
    public class buff_da_DoubleSide_Rate : Buff
    {
        public buff_da_DoubleSide_Rate()
        {
            buff_name = this.GetType().Name;
            buff_Type = 6;
            buff_or_Db = status_List.buff.ToString();
            start_at_Turn = Turns.turn;
            affect_turns = 1;
            end_at_trun = start_at_Turn + affect_turns;
        }
    }
    public class buff_ta_SingleSide_Rate : Buff
    {
        public buff_ta_SingleSide_Rate()
        {
            buff_name = this.GetType().Name;
            buff_Type = 7;
            buff_or_Db = status_List.buff.ToString();
            start_at_Turn = Turns.turn;
            affect_turns = 1;
            end_at_trun = start_at_Turn + affect_turns;
        }
    }
    public class buff_ta_DoubleSide_Rate : Buff
    {
        public buff_ta_DoubleSide_Rate()
        {
            buff_name = this.GetType().Name;
            buff_Type = 8;
            buff_or_Db = status_List.buff.ToString();
            start_at_Turn = Turns.turn;
            affect_turns = 1;
            end_at_trun = start_at_Turn + affect_turns;
        }
    }
    public class buff_ca_SingleSide_Rate : Buff
    {
        public buff_ca_SingleSide_Rate()
        {
            buff_name = this.GetType().Name;
            buff_Type = 9;
            buff_or_Db = status_List.buff.ToString();
            start_at_Turn = Turns.turn;
            affect_turns = 1;
            end_at_trun = start_at_Turn + affect_turns;
        }
    }
    public class buff_ca_DoubleSide_Rate : Buff
    {
        public buff_ca_DoubleSide_Rate()
        {
            buff_name = this.GetType().Name;
            buff_Type = 10;
            buff_or_Db = status_List.buff.ToString();
            start_at_Turn = Turns.turn;
            affect_turns = 1;
            end_at_trun = start_at_Turn + affect_turns;
        }
    }
    public class buff_revive : Buff
    {
        public buff_revive()
        {
            buff_name = this.GetType().Name;
            buff_Type = 11;
            buff_or_Db = status_List.buff.ToString();
            start_at_Turn = Turns.turn;
            affect_turns = 1;
            end_at_trun = start_at_Turn + affect_turns;
        }
    }
    public class buff_SklSealed : Buff
    {
        public buff_SklSealed()
        {
            buff_name = this.GetType().Name;
            buff_Type = 12;
            buff_or_Db = status_List.buff.ToString();
            start_at_Turn = Turns.turn;
            affect_turns = 1;
            end_at_trun = start_at_Turn + affect_turns;
        }
    }
    public class buff_isCaSealed : Buff
    {
        public buff_isCaSealed()
        {
            buff_name = this.GetType().Name;
            buff_Type = 12;
            buff_or_Db = status_List.buff.ToString();
            start_at_Turn = Turns.turn;
            affect_turns = 1;
            end_at_trun = start_at_Turn + affect_turns;
        }
    }
    public class buff_isAtkSealed : Buff
    {
        public buff_isAtkSealed()
        {
            buff_name = this.GetType().Name;
            buff_Type = 12;
            buff_or_Db = status_List.buff.ToString();
            start_at_Turn = Turns.turn;
            affect_turns = 1;
            end_at_trun = start_at_Turn + affect_turns;
        }
    }
    public class db_atk_SingleSide_Rate : Buff
    {
        public db_atk_SingleSide_Rate()
        {
            buff_name = this.GetType().Name;
            buff_Type = -1;
            buff_or_Db = status_List.debuff.ToString();
            start_at_Turn = Turns.turn;
            affect_turns = 1;
            end_at_trun = start_at_Turn + affect_turns;
        }
    }
    public class db_atk_DoubleSide_Rate : Buff
    {
        public db_atk_DoubleSide_Rate()
        {
            buff_name = this.GetType().Name;
            buff_Type = -2;
            buff_or_Db = status_List.debuff.ToString();
            start_at_Turn = Turns.turn;
            affect_turns = 1;
            end_at_trun = start_at_Turn + affect_turns;
        }
    }
    public class db_def_SingleSide_Rate : Buff
    {
        public db_def_SingleSide_Rate()
        {
            buff_name = this.GetType().Name;
            buff_Type = -3;
            buff_or_Db = status_List.debuff.ToString();
            start_at_Turn = Turns.turn;
            affect_turns = 1;
            end_at_trun = start_at_Turn + affect_turns;
        }
    }
    public class db_def_DoubleSide_Rate : Buff
    {
        public db_def_DoubleSide_Rate()
        {
            buff_name = this.GetType().Name;
            buff_Type = -4;
            buff_or_Db = status_List.debuff.ToString();
            start_at_Turn = Turns.turn;
            affect_turns = 1;
            end_at_trun = start_at_Turn + affect_turns;
        }
    }
    public class db_da_SingleSide_Rate : Buff
    {
        public db_da_SingleSide_Rate()
        {
            buff_name = this.GetType().Name;
            buff_Type = -5;
            buff_or_Db = status_List.debuff.ToString();
            start_at_Turn = Turns.turn;
            affect_turns = 1;
            end_at_trun = start_at_Turn + affect_turns;
        }
    }
    public class db_da_DoubleSide_Rate : Buff
    {
        public db_da_DoubleSide_Rate()
        {
            buff_name = this.GetType().Name;
            buff_Type = -6;
            buff_or_Db = status_List.debuff.ToString();
            start_at_Turn = Turns.turn;
            affect_turns = 1;
            end_at_trun = start_at_Turn + affect_turns;
        }
    }
    public class db_ta_SingleSide_Rate : Buff
    {
        public db_ta_SingleSide_Rate()
        {
            buff_name = this.GetType().Name;
            buff_Type = -7;
            buff_or_Db = status_List.debuff.ToString();
            start_at_Turn = Turns.turn;
            affect_turns = 1;
            end_at_trun = start_at_Turn + affect_turns;
        }
    }
    public class db_ta_DoubleSide_Rate : Buff
    {
        public db_ta_DoubleSide_Rate()
        {
            buff_name = this.GetType().Name;
            buff_Type = -8;
            buff_or_Db = status_List.debuff.ToString();
            start_at_Turn = Turns.turn;
            affect_turns = 1;
            end_at_trun = start_at_Turn + affect_turns;
        }
    }
    public class db_ca_SingleSide_Rate : Buff
    {
        public db_ca_SingleSide_Rate()
        {
            buff_name = this.GetType().Name;
            buff_Type = -9;
            buff_or_Db = status_List.debuff.ToString();
            start_at_Turn = Turns.turn;
            affect_turns = 1;
            end_at_trun = start_at_Turn + affect_turns;
        }
    }
    public class db_ca_DoubleSide_Rate : Buff
    {
        public db_ca_DoubleSide_Rate()
        {
            buff_name = this.GetType().Name;
            buff_Type = -10;
            buff_or_Db = status_List.debuff.ToString();
            start_at_Turn = Turns.turn;
            affect_turns = 1;
            end_at_trun = start_at_Turn + affect_turns;
        }
    }
    public class revive : Buff
    {
        public revive()
        {
            buff_name = this.GetType().Name;
            buff_Type = -11;
            buff_or_Db = status_List.debuff.ToString();
            start_at_Turn = Turns.turn;
            affect_turns = 1;
            end_at_trun = start_at_Turn + affect_turns;
        }
    }
    public class SklSealed : Buff
    {
        public SklSealed()
        {
            buff_name = this.GetType().Name;
            buff_Type = -12;
            buff_or_Db = status_List.debuff.ToString();
            start_at_Turn = Turns.turn;
            affect_turns = 1;
            end_at_trun = start_at_Turn + affect_turns;
        }
    }
    public class death : Buff
    {
        public death()
        {
            buff_name = this.GetType().Name;
            buff_Type = -13;
            buff_or_Db = status_List.debuff.ToString();
            start_at_Turn = Turns.turn;
            affect_turns = 1;
            end_at_trun = start_at_Turn + affect_turns;
        }
    }
    public class iSAtkSealed : Buff
    {
        public iSAtkSealed()
        {
            buff_name = this.GetType().Name;
            buff_Type = 14;
            buff_or_Db = status_List.debuff.ToString();
            start_at_Turn = Turns.turn;
            affect_turns = 1;
            end_at_trun = start_at_Turn + affect_turns;
        }
    }

    public class Vira_variable_buff_Test : buff_atk_DoubleSide_Rate
    {
        public override void buff_refresh()
        {
            _atk_DoubleSide_Rate = 0.15 * (Turns.turn + 1 - start_at_Turn);
        }
        public Vira_variable_buff_Test()
        {
            affect_turns = 3;
            start_at_Turn = Turns.turn;
            end_at_trun = start_at_Turn + affect_turns;
            _atk_DoubleSide_Rate = 0.15;
        }
    }
    public class Vira_SKL1_atk_single_buff : buff_atk_SingleSide_Rate
    {
        public override void buff_refresh()
        {

        }
        public Vira_SKL1_atk_single_buff()
        {
            affect_turns = 3;
            start_at_Turn = Turns.turn;
            end_at_trun = start_at_Turn + affect_turns;
            _atk_SingleSide_Rate = 0.15;
        }
    }
    public class Vira_SKL1_def_single_buff : buff_def_SingleSide_Rate
    {
        public override void buff_refresh()
        {

        }
        public Vira_SKL1_def_single_buff()
        {
            affect_turns = 4;
            start_at_Turn = Turns.turn;
            end_at_trun = start_at_Turn + affect_turns;
            _def_SingleSide_Rate = 0.15;
        }
    }
}
