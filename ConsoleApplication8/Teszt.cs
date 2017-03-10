using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication8
{
    public class Teszt
    {
        private MesterEmber[] Foni = new MesterEmber[6];

        public Teszt()
        {
            Foni[0] = new Burkoló("Tapéta Lajos", 60.000, BurkolóTípus.Belső);
            Foni[1] = new VízvezetékSzerelő("Megszer Elek", 12.000, 3);
            Foni[2] = new Burkoló("Vakolat Péter", 50.000, BurkolóTípus.Külső);
            Foni[3] = new VízvezetékSzerelő("Víz Elek", 15.000, 5);
            Foni[4] = new Burkoló("Eresz János", 30.000, BurkolóTípus.Külső);

        }
    }
}