using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBF_Sample01
{
    public interface iFmWork
    {
        void say_wAtk();
        void say_wDie();
        void attack(Attribute a);
        void death_Checker();
        void die();
    }
    public interface Iskl
    {
        void casting();
        void CD_End_Imm();
    }
    public abstract class Skl : Iskl
    {
        public Attribute who_casting;
        public List<Attribute> casting_target = new List<Attribute>();
        public string skl_Name;
        public int cool_Down;
        public int available_On_Turn;
        public abstract void casting();
        public void CD_End_Imm()
        {
            available_On_Turn = 0;
        }
        public Skl()
        {

        }
    }
    public interface IAtk
    {

    }


    public interface IChapters
    {

    }
    public abstract class Chapter : IChapters
    {
        public List<Enemy> enemy_List = new List<Enemy>();
        public List<Charactor> charactor_List = new List<Charactor>();




    }


}
