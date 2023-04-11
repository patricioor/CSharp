namespace CSharp.API
{
    internal class Diretorios
    {
        public static void Executar()
        {
            var novoDir = @"~/PastaCSharp".ParseHome();
            var novoDirDestino = @"~/PastaCSharpDestino".ParseHome();
            var dirProjeto = @"C:\Users\patri\source\repos\CSharp\CSharp";

            if (Directory.Exists(novoDir)) Directory.Delete(novoDir, true);
            if (Directory.Exists(novoDirDestino)) Directory.Delete(novoDirDestino, true);

            Directory.CreateDirectory(novoDir);
            Console.WriteLine(Directory.GetCreationTime(novoDir));

            Console.WriteLine("== Pastas =======");
            var pastas = Directory.GetDirectories(dirProjeto);
            foreach(var pasta in pastas) Console.WriteLine(pasta);

            Console.WriteLine("\n\n == Arquivos ========");
            var arquivos = Directory.GetFiles(dirProjeto);
            foreach (var arquivo in arquivos) Console.WriteLine(arquivo);

            Console.WriteLine("\n\n == Root =======");
            var root = Directory.GetDirectoryRoot(dirProjeto);
            Console.WriteLine(root);

            Console.WriteLine("\n\n Movendo Diretórios");
            var varNovoDir = Directory.GetDirectories(@"~".ParseHome());
            foreach(var dir in varNovoDir) Console.WriteLine(dir);

            Directory.Move(novoDir, novoDirDestino); //movimenta o diretório anterior já criando o novo diretório destino

            Console.WriteLine("\n\n Após a movimentação");
            var varNovoDirDest = Directory.GetDirectories(@"~".ParseHome());
            foreach(var novoDirDest in varNovoDirDest) Console.WriteLine(novoDirDest);
        }
    }
}
