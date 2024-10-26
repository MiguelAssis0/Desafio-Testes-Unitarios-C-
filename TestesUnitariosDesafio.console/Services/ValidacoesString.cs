using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestesUnitariosDesafio.console.Services
{
    public class ValidacoesString
    {
        public int RetornarQTDECaracteres(string texto)
        {
            return texto.Length;
        }

        public bool ContemDeterminadoCaracter(string texto, string caracter)
        {
            return texto.ToUpper().Contains(caracter.ToUpper());
        }

        public bool TextoTerminaCom(string texto, string caracter)
        {
            return texto.ToUpper().EndsWith(caracter.ToUpper());
        }
    }
}