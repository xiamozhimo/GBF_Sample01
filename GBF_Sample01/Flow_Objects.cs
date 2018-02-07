using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBF_Sample01
{
    public class Flow_Objects
    {
        Random rand = new System.Random();
        private double damage_Float;
        public double randFloat()
        {
            damage_Float = ((rand.NextDouble() / 5.0) - 0.1 + 1.0);
            return damage_Float;
        }
        //攻击次数
        private int attackTimes;
        public int mutiAtkTimes(Attribute a)
        {
            double multiAtk_Checker = rand.NextDouble();
            if (multiAtk_Checker <= a.ta_rate)
               {
                   attackTimes = 3;
               }
               else if (multiAtk_Checker <= a.da_rate)
               {
                   attackTimes = 2;
               }
               else
               {
                   attackTimes = 1;
               }
            return attackTimes;
        }
        //是否暴击
        private bool isCritical;
        public bool isCrit_Checker(Attribute a)
        {
             double cretical_Checker = rand.NextDouble();
             if (cretical_Checker <= a.critical_Posibility)
                {
                    isCritical = true;
                }
                else
                {
                    isCritical = false;
                }
            return isCritical;
        }
        //暴击倍率
        double critDMG_Ptg;
        public double critical(Attribute a, bool isCritical)
        {
            if (isCritical == true)
            {
                critDMG_Ptg = 1.00 + a.critical_Rate;
            }
            else
            {
                critDMG_Ptg = 1.00;
            }
            return critDMG_Ptg;
        }
        
        //CA获取（通过攻击）
        public void CA_Increase(Attribute a,int mutiAtkTimes)
        {
            if (a.GetType().BaseType == typeof(Enemy))
            {
                a.ca = a.ca + 1;
                if (a.ca > a.ca_max)
                {
                    a.ca = a.ca_max;
                }
            }
            else if (a.GetType().BaseType == typeof(Charactor))
            {
                if (attackTimes == 3)
                {
                    a.ca = a.ca + (int)(Math.Ceiling(10 * a.default_CA_rate) * 3 + Math.Ceiling(2 * a.default_CA_rate) + Math.Ceiling(5 * a.default_CA_rate));
                }
                else if (attackTimes == 2)
                {
                    a.ca = a.ca + (int)(Math.Ceiling(10 * a.default_CA_rate) * 2 + Math.Ceiling(2 * a.default_CA_rate));
                }
                else if (attackTimes == 1)
                {
                    a.ca = a.ca + (int)(Math.Ceiling(10 * a.default_CA_rate)) * 1;
                }
                if (a.ca > a.ca_max)
                {
                    a.ca = a.ca_max;
                }
            }         
        }
        //CA获取（不通过攻击）
        public void CA_Increase(Charactor c, int CA_upAmount)
        {
            c.ca = c.ca + (int)(Math.Ceiling(CA_upAmount * c.default_CA_rate)) * 1;
        }
        //死亡校验
        public void dead_Checker(Attribute a)
        {
            if (a.hp <= 0)
            {
                a.isAlive = false;
                a.hp = 0;
            }      
        }
        //单位基本状态显示
        public void battle_Object_Detail(Charactor c)
        {
            Console.WriteLine("\r\n{0}\r\n", c.name);
            Console.WriteLine("HP {0}\r\nC.A. {1}\r\n", c.hp, c.ca);
            Console.WriteLine("Atk {0}\r\nDef {1}", c._atk, c._def);
            Console.WriteLine("Side\r\nPosition \r\n");

        }
        public void battle_Object_Detail(Enemy e)
        {
            Console.WriteLine("{0}\r\n", e.name);
            Console.WriteLine("HP {0}\r\nOrbs {1}\r\n", e.hp, e.ca);
            //Console.WriteLine("---------------Hidden---------------");
            //Console.WriteLine("Atk {0}\r\nDef {1}", e.atk, e.def);
            //Console.WriteLine("Side {0}\r\nPosition {1}", e.side, e.position);
            //Console.WriteLine("---------------Hidden---------------\r\n");
        }
        //单位buff显示
        public void battle_Object_Buff_Show(Charactor c)
        {
            foreach (Buff b in c.buff)
            {
                    Console.WriteLine("状态名称：{0}", b.buff_name);
                    Console.WriteLine("状态类型：{0}", b.buff_Type);
                    Console.WriteLine("状态剩余持续时间：{0}", b.end_at_trun - Turns.turn);
                    Console.WriteLine("\r\n");
            }
        }
    }
}
