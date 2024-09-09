using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ca_Nome_prova
{
    internal class NomeProprio
    {
        private string nome_completo;
        private string nome_paper;

        public string Nome_completo { get => nome_completo; set => nome_completo = value; }
        public string Nome_paper { get => nome_paper; set => nome_paper = value; }

        public NomeProprio()
        {
            nome_completo = string.Empty;
            nome_paper = string.Empty;
        }

        public NomeProprio(string _nome_completo)
        {
            nome_completo = _nome_completo;
            gerarNomePaper();
        }

        private void gerarNomePaper()
        {
            string[] partes = nome_completo.Split(' ');

            if(partes.Length == 3)
            {
                string first_name = partes[0];
                string middle_name = partes[1];
                string last_name = partes[2];

                nome_paper = last_name + ", " + first_name + ' ' + middle_name[0] + '.';

            }
            
            else
            {
                if(partes.Length == 2)
                {
                    string first_name = partes[0];
                    string last_name = partes[1];


                    nome_paper = last_name + ", " + first_name;
                }
            }

        }

        public void ImprimeNomePaper()
        {
            Console.WriteLine(nome_paper);
        }
    }
}
