using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication8
{
    public class MesterEmber
    {
        public String Név;
        public int Napidíj;
        public bool[] Foglaltnapok = new bool[31];
      

        public MesterEmber(string Név, int Napidíj)
        {
            this.Név = Név;
            this.Napidíj = Napidíj;

            for (int i = 0; i < 31; i++)
                Foglaltnapok[i] = true;
        }

        public string MindenAdat()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(Név);
            sb.Append(Napidíj);
            sb.Append(Foglaltnapok);
            sb.AppendLine();

            return sb.ToString();
        }

        public abstract MunkátVállal(int Nap);
     
    }
}