using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ca_Nome_prova
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NomeProprio x = new NomeProprio("Edgard Afonso Lamounier");
            x.ImprimeNomePaper();

            NomeProprio y= new NomeProprio("Edgard A. Lamounier");
            y.ImprimeNomePaper();

            NomeProprio z = new NomeProprio("Edgard Lamounier");
            z.ImprimeNomePaper();
           
            Console.ReadLine();
        }
    }
}
