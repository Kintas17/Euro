using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euro
{
    class euromilhoes
    {
        private int nestrela = 0, nnumeros = 0;

        private const string cruz = "X";
        private bool[] numeros = new bool[50];
        private bool[] estrelas = new bool[12];

        public string numero(int n)
        {
            if (numeros[n])
            {
                numeros[n] = false;
                nnumeros--;
            }

            else if (nnumeros < 5)
            {
                numeros[n] = true;
                nnumeros++;
            }
            if (numeros[n]) return cruz;
            else return "";

        }
        public string estrela(int n)
        {
            if (estrelas[n])
            {
                estrelas[n] = false;
                nestrela--;
            }

            else if (nestrela < 2)
            {
                estrelas[n] = true;
                nestrela++;
            }
            if (estrelas[n]) return cruz;
            else return "";

        }
        public string listanum
        {
            get
            {
                string lista = "";
                for (int i = 0; i < 50; i++)
                    if (numeros[i])
                    {
                        if (lista != "") lista += "+";
                        lista += (i + 1).ToString();
                    }
                return lista;
            }
        }
        public string listaest  
        {
            get
            {
                string lista = "";
                for (int i = 0; i < 12; i++)
                    if (estrelas[i])
                    {
                        if (lista != "") lista += "+";
                        lista += (i + 1 ).ToString();
                    }
                return lista;
            }
        }
        public string sorteion
        {
            get
            {
                int min = 1;
                int max = 50;
                Random random = new Random();
                return Convert.ToString(random.Next(min, max)) + "+" + Convert.ToString(random.Next(min, max) + "+" + Convert.ToString(random.Next(min, max) + "+" + Convert.ToString(random.Next(min, max) + "+" + Convert.ToString(random.Next(min, max)))));
            }
        }
        public string sorteioe
        {
            get
            {
                int min = 1;
                int max = 12;
                Random random = new Random();
                return Convert.ToString(random.Next(min, max)) + "+" + Convert.ToString(random.Next(min, max));
            }
        }
    }
}