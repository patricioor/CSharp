namespace CSharp.API
{
    internal class LendoArquivos
    {
        public class TextNullException : Exception
        {
            public TextNullException(string message) : base(message) { }
            public TextNullException() { }
        }

        public static string ProcurandoTexto(string texto)
        {
            if (texto == "") throw new TextNullException("Não há texto digitado neste arquivo");
            return texto;
        }
        public static void Executar()
        {
            var path = @"~/Lendo_Arquivos.txt".ParseHome();

            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine("Produto;Preco;Qtde");
                    sw.WriteLine("Caneta Bic Preta; 3.59; 89");
                    sw.WriteLine("Borracha Branca;2.58;28");
                }
            }
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    var texto = sr.ReadToEnd();
                    Console.WriteLine(ProcurandoTexto(texto));
                }
            }
            catch (TextNullException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

