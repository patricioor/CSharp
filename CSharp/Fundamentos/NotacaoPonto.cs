namespace Projeto_CSharp.Fundamentos {
    class NotacaoPonto {
        public static void Executar() {
            var saudacao = "olá".ToUpper().Insert(3, ", World!").Replace(", World!", ", Mundo!");
            Console.WriteLine(saudacao);

            Console.WriteLine("teste".Length);

            string valorImportante = null;

            // colocando o "?" entre a variável e o ponto vai previnir a execução caso falhe
            Console.WriteLine(valorImportante?.Length);

            Console.WriteLine("E não vai impedir a execução do código");
        }
    }
}
