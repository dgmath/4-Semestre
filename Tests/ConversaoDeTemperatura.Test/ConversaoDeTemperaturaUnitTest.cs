namespace ConversaoDeTemperatura.Test
{
    public class ConversaoDeTemperaturaUnitTest
    {
        [Fact]
        public static void ConverterTest()
        {
            var temperatura = 24;

            var esperado = 75.2;

            var resultado = Temperatura.ConverterCelsiusParaFahrenheit(temperatura);

            Assert.Equal(esperado, resultado);
        }
    }
}