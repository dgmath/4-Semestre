namespace ValidacaoDeEmail.Test
{
    public class ValidacaoDeEmailUnitTest
    {
        
            [Theory]

            [InlineData("math29kis@gmail.com")]
            [InlineData("math29kis@gmailcom")]
            [InlineData("math29kisgmailcom")]
        public static void ValidacaoDeEmailTest(string email)
        {
            var resultado = ValidacaoDeEmail.ValidarEmail(email);

            // Assert
            Assert.True(resultado);
        }
    }
}   