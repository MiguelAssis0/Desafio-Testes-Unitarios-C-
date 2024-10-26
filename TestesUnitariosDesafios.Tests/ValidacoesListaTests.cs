using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestesUnitariosDesafio.console.Services;
using Xunit;

namespace TestesUnitariosDesafios.Tests
{
    public class ValidacoesListaTests
    {
        [Fact]

        public void DeveRemoverNumerosNegativosDeUmaLista()
        {

            var lista = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, -1, -2, -3, -4, -5, -6, -7, -8, -9, -10 };
            ValidacoesLista validacao = new ValidacoesLista();
            var resultado = validacao.RemoverNumerosNegativos(lista);
            Assert.Equal(new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, resultado);
        }

        [Fact]
        public void DeveConterONumero9NaLista()
        {
            var lista = new List<int> { 1,2,3,4,5,6,7,8,9,10};
            ValidacoesLista validacao = new ValidacoesLista();
            var resultado = validacao.ContemDeterminadoNumero(lista, 9);
            Assert.True(resultado);
        }

        [Fact]
        public void NaoDeveConterONumero10NaLista()
        {
            var lista = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            ValidacoesLista validacao = new ValidacoesLista();
            var resultado = validacao.ContemDeterminadoNumero(lista, 10);
            Assert.False(resultado);
        }

        [Fact]
        public void DeveMultiplicarOsElementosPor2()
        {
            var lista = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            ValidacoesLista validacao = new ValidacoesLista();
            var resultado = validacao.MultiplicarNumerosLista(lista, 2);
            Assert.Equal(new List<int> { 2, 4, 6, 8, 10, 12, 14, 16, 18, 20 }, resultado);
        }

        [Fact]
        public void DeveRetornar9ComoMaiorNumero()
        {
            var lista = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            ValidacoesLista validacao = new ValidacoesLista();
            var resultado = validacao.RetornarMaiorNumero(lista);
            Assert.Equal(9, resultado);
        }

        [Fact]
        public void DeveRetornar8NegativoComoMenorNumero()
        {
            var lista = new List<int> { -8, -7, -6, -5, -4, -3, -2, -1, 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            ValidacoesLista validacao = new ValidacoesLista();
            var resultado = validacao.RetornarMenorNumero(lista);
            Assert.Equal(-8, resultado);
        }
    }
}