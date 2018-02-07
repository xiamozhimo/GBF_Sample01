using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GBF_Sample01
{
    public class Program
    {
        static void Main(string[] args)
        {
            BattleField.Ba_Initialize ba = new BattleField.Ba_Initialize();
            Flow_Objects flo = new Flow_Objects();
            foreach (Enemy E in BattleField.bf_E)
            {
                flo.battle_Object_Detail(E);
            }
            foreach (Charactor C in BattleField.bf_C)
            {
                flo.battle_Object_Detail(C);
            }

            BattleField.bf_C[0].skill[0].casting();

            foreach (Charactor C in BattleField.bf_C)
            {
                flo.battle_Object_Detail(C);
            }
            Console.ReadLine();
            Console.WriteLine("02072018 2:09 p.m.");
























            //Charactor vira = new Vira();
            //Enemy bahamut = new Bahamut();
            //Turns_Manager tm = new Turns_Manager();
            //Flow_Objects flo = new Flow_Objects();

            //tm.Turn_show();
            //vira.buff_reCalc();
            //flo.battle_Object_Detail(vira);

            //vira.skl1();
            //vira.skl1();
            //vira.skl1();
            //foreach (Buff b in vira.buff)
            //{
            //    Console.WriteLine(b._atk_SingleSide_Rate);
            //    Console.WriteLine(b._atk_DoubleSide_Rate);
            //}
            //flo.battle_Object_Detail(vira);
            //flo.battle_Object_Buff_Show(vira);
            //vira.buff_reCalc();
            //tm.Turn_Add();
            //tm.Turn_show();

            //vira.buff_reCalc();
            //vira.skl1();
            //flo.battle_Object_Detail(vira);
            //flo.battle_Object_Buff_Show(vira);
            //vira.buff_reCalc();
            //tm.Turn_Add();
            //tm.Turn_show();

            //vira.buff_reCalc();
            //flo.battle_Object_Detail(vira);
            //flo.battle_Object_Buff_Show(vira);
            //vira.buff_reCalc();
            //tm.Turn_Add();
            //tm.Turn_show();


            //vira.buff_reCalc();
            //flo.battle_Object_Detail(vira);
            //flo.battle_Object_Buff_Show(vira);
            //vira.buff_reCalc();
            //tm.Turn_Add();
            //tm.Turn_show();

            //vira.buff_reCalc();
            //flo.battle_Object_Detail(vira);
            //flo.battle_Object_Buff_Show(vira);
            //vira.buff_reCalc();
            //tm.Turn_Add();
            //tm.Turn_show();





        }
    }
}
