using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestesUnitariosDesafio.console.Services
{
    public class ValidacoesLista
    {
        public List<int> RemoverNumerosNegativos(List<int> lista)
        {
            List<int> newList = new List<int>();
            foreach (var item in lista)
            {
                if(item > 0)
                {
                    newList.Add(item);
                }
            }
            return newList;
        }

        public bool ContemDeterminadoNumero(List<int> lista, int numero)
        {
            foreach (var item in lista)
            {
                if (item == numero)
                {
                    return true;
                }
            }
            return false;
        }

        public List<int> MultiplicarNumerosLista(List<int> lista, int multiplicador)
        {
            List<int> newList = new List<int>();
            foreach(var item in lista)
            {
                newList.Add(item * multiplicador);
            }
            return newList;
        }

        public int RetornarMaiorNumero(List<int> lista)
        {
            return lista.Max();
        }

        public int RetornarMenorNumero(List<int> lista)
        {
            return lista.Min();
        }
        

    }
}