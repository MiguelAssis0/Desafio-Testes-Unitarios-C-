using System;
using System.Collections.Generic;
using System.Linq;
using TestesUnitariosDesafio.console.Services;
using System.Threading.Tasks;
using Xunit;

namespace TestesUnitariosDesafios.Tests
{
    public class ValidacoesStringTests
    {
        [Fact]
        public void DeveRetornar6QuantidadeDeCaracteresDaPalavraMatrix()
        {
            string texto = "Matrix";
            ValidacoesString validacao = new ValidacoesString();
            var resultado = validacao.RetornarQTDECaracteres(texto);

            Assert.Equal(6, resultado);
        }

        [Fact]
        public void DeveConterAPalavraQualquerNoTexto()
        {
            string palavra = "Qualquer";
            string texto = "Esse é um texto qualquer";

            ValidacoesString validacao = new ValidacoesString();
            var resultado = validacao.ContemDeterminadoCaracter(texto, palavra);

            Assert.True(resultado);
        }

        [Fact]
        public void NaoDeveConterAPalavraTesteNoTexto()
        {
            string palavra = "Teste";
            string texto = "Esse é um texto qualquer";

            ValidacoesString validacao = new ValidacoesString();
            var resultado = validacao.ContemDeterminadoCaracter(texto, palavra);

            Assert.False(resultado);
        }

        [Fact]
        public void TextoDeveTerminarComAPalavraProcurado()
        {
            string palavra = "procurado";
            string texto = "Esse é um texto procurado";

            ValidacoesString validacao = new ValidacoesString();
            var resultado = validacao.TextoTerminaCom(texto, palavra);

            Assert.True(resultado);
        }
    }
}