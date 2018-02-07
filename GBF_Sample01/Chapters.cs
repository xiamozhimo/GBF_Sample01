using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GBF_Sample01
{
    public class Chapter_1 : Chapter
    {
        public Chapter_1()
        {
            Vira vira = new Vira();
            Bahamut baha = new Bahamut();
            this.enemy_List.Add(baha);
            this.charactor_List.Add(vira);
        }
    }
    public class Chapter_2 : Chapter
    {
        
    }
}
