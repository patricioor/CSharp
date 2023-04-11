namespace CSharp.API
{
    public static class ExtensaoString
    {
        public static string ParseHome(this string path)
        {
            string home = "C:\\Users\\patri\\OneDrive\\Documentos\\Patrício\\Programação\\Primeiro Arquivo";

            return path.Replace("~", home);
        }
    }
    internal class PrimeiroArquivo
    {
        public static void Executar()
        {
            var path = @"~/primeiro_arquivo.txt".ParseHome();

            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("Esse é");
                    sw.WriteLine("O meu");
                    sw.WriteLine("primeiro");
                    sw.WriteLine("Arquivo");
                }
            }
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine("");
                sw.WriteLine(Console.ReadLine());
               
            
            }
        }
    }
}
