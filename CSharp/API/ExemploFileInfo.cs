namespace CSharp.API
{
    internal class ExemploFileInfo
    {
        public static void ExcluirSeExistir (params string[] caminhos)
        {
            foreach(var caminho in caminhos) 
            { 
                FileInfo arquivo = new FileInfo(caminho);
                
                if(arquivo.Exists) arquivo.Delete();
            }
        }
        public static void Executar()
        {
            var caminhoOrigem = @"~/arq_origem.txt".ParseHome();
            var caminhoDestino = @"~/arq_destino.txt".ParseHome();
            var caminhoCopia = @"~/arq_copia.txt".ParseHome();

            ExcluirSeExistir(caminhoOrigem, caminhoCopia, caminhoDestino); //deletar todos os arquivos originados anteriormente para o novo teste.

            using (StreamWriter sw = File.CreateText(caminhoOrigem))
            {
                sw.WriteLine("Arquivo Original!");
            }

            FileInfo origem = new FileInfo(caminhoOrigem);
            Console.WriteLine("Qual o nome do arquivo? {0}", origem.Name);
            Console.WriteLine("O arquivo está categorizado como 'somente leitura'? {0}", origem.IsReadOnly);
            Console.WriteLine("Qual o caminho do arquivo 'arq_origem.txt'? {0}", origem.FullName);
            Console.WriteLine("Qual a extensão do arquivo? {0}", origem.Extension);

            origem.CopyTo(caminhoCopia);
            origem.MoveTo(caminhoDestino);
        }
    }
}
