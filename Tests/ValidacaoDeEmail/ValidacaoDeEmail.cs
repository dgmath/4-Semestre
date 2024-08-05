using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ValidacaoDeEmail
{
    public static class ValidacaoDeEmail
    {
        // Exercício 2: Teste de Validação de Email
        // Crie um teste unitário para o método ValidarEmail que verifica se um email é validado corretamente.
        // Exemplo: se o email passado contém "@"  e  " . "
        //Contains("@") && email.Contains(".");
        public static bool ValidarEmail(string email)
        {
            var split = email.Split("@");

            var contains = split[1].Contains(".");

            return contains;
        }
    }
}
