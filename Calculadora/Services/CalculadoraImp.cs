using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora.Services
{
    public class CalculadoraImp
    {
        /*
        public int somar(int num1, int num2)
        {
            return num1 + num2;
        }

        public bool EhPar(int num)
        {
            return num % 2 == 0;
        }
        */

        private List<string> listaHistorico;
        private string data;

        public CalculadoraImp(string data)
        {
            listaHistorico = new List<string>();
            this.data = data;
        }
        public int somar(int val1, int val2)
        {
            int res = val1 + val2;
            listaHistorico.Insert(0, "Res" + res + " - data: " + data);
            return  res;
        }

        public int subtrair(int val1, int val2)
        {
             int res = val1 - val2;
            listaHistorico.Insert(0, "Res" + res + " - data: " + data);
            return  res;
        }

        public int mutiplicar(int val1, int val2)
        {
             int res = val1 * val2;
            listaHistorico.Insert(0, "Res" + res + " - data: " + data);
            return  res;
        }

        public int dividir(int val1, int val2)
        {
             int res = val1 / val2;
            listaHistorico.Insert(0, "Res" + res + " - data: " + data);
            return  res;
        }

        public List<string> historico()
        {
            //Remove os intens da lista deixando somente os 3 primeiros
            listaHistorico.RemoveRange(3, listaHistorico.Count - 3);
            return listaHistorico;
        }
    }
}