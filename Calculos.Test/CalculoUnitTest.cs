using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos.Test
{
    public class CalculoUnitTest
    {
        //notation que especifica o metodo como metodo de teste
        [Fact]
        public void SomarDoisNumeros()
        {
            var n1 = 3.3;
            var n2 = 2.2;

            var valorEsperado = 5.5;

            var soma = Calculo.Somar(n1 , n2);

            //metodo de comparação
            Assert.Equal(valorEsperado, soma);
        }

        [Fact]
        public void ModuloDoNumero()
        {
            var n = -10;
            var valorEsperado = 10;

            var modulo = Calculo.Modulo(n);

            Assert.Equal(valorEsperado, modulo);
        }

        [Fact]
        public void SubtrairDoisNumeros()
        {
            var n1 = 20;
            var n2 = 15;

            var valorEsperado = 5;

            var resultado = Calculo.Subtrair(n1, n2);

            //metodo de comparação
            Assert.Equal(valorEsperado, resultado);
        }

        [Fact]
        public void DividirDoisNumeros()
        {
            var n1 = 20;
            var n2 = 5;

            var valorEsperado = 4;

            var resultado = Calculo.Dividir(n1, n2);

            //metodo de comparação
            Assert.Equal(valorEsperado, resultado);
        }

        [Fact]
        public void MultiplicarDoisNumeros()
        {
            var n1 = 3;
            var n2 = 9;

            var valorEsperado = 27;

            var resultado = Calculo.Multiplicar(n1, n2);

            //metodo de comparação
            Assert.Equal(valorEsperado, resultado);
        }
    }
}
