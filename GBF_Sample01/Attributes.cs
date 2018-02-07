using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBF_Sample01
{
    public abstract class Attribute : iFmWork
    {
        public string name { get; set; }

        public int hp_Max { get; set; }
        public int hp { get; set; }

        public int atk;
        public double def { get; set; }

        public int _atk { get; set; }
        public double _def { get; set; }

        public double db_suc_rate { get; set; }
        public double db_imm_rate { get; set; }

        public double _db_suc_rate { get; set; }
        public double _db_imm_rate { get; set; }

        public List<Skl> skill = new List<Skl>();


        public double critical_Posibility { get; set; }
        public double critical_Rate { get; set; }
        public List<Buff> buff = new List<Buff>();

        public bool isAlive;
        public bool isSklSealed;
        public bool isCaSealed;
        public bool iSAtkSealed;



        public int ca { get; set; }
        public int ca_max { get; set; }
        public int ca_min;
        public double default_CA_rate { get; set; }
        public double da_rate { get; set; }
        public double ta_rate { get; set; }
        public enum sidelist
        {
            Ally = 1,
            Enemy = 0
        }

        public Attribute target_Enemy;
        public Attribute target_Ally;

        public Attribute()
        {
            ca_min = 0;

        }
        public virtual void say_wAtk()
        {

        }
        public virtual void say_wDie()
        {

        }
        public void attack(Attribute a)
        {
            var atk = new Atk();
            atk.attack(this, a);
        }
        public void buff_reCalc()
        {
            foreach (Buff b in buff)
            {
                b.buff_refresh();
            }

            while (!(this.buff.FindIndex(x => x.end_at_trun<=Turns.turn)==-1))
            {
                this.buff.RemoveAt(this.buff.FindIndex(x => x.end_at_trun <= Turns.turn));
            }

            _atk = (int)(atk * (1.0 + buff.Sum(b => b._atk_SingleSide_Rate)) * (1.0 + buff.Sum(b => b._atk_DoubleSide_Rate)));
            _def = (def * (1.0 + buff.Sum(b => b._def_SingleSide_Rate)) * (1.0 + buff.Sum(b => b._def_DoubleSide_Rate)));
        }
        public void death_Checker()
        {
            if (this.hp <= 0)
            {
                this.die();
            }
        }
        public void die()
        {
            this.isAlive = false;
            this.hp = 0;         
        }
    }
}
