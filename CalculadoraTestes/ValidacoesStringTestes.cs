using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Calculadora.Services;

namespace CalculadoraTestes
{
    public class ValidacoesStringTestes
    {
        private ValidacoesString _validacoes;

        public ValidacoesStringTestes()
        {
            _validacoes = new ValidacoesString();
        }

        [Fact]
        public void DeveContar3caracteresEmOlaERetornar3()

        {
            // Given
            string texto = "Ola";
            // When
            int resultado = _validacoes.ContarCaracteres(texto);
            // Then
            Assert.Equal(3, resultado);
        }
    }
}