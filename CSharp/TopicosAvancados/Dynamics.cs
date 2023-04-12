namespace CSharp.TopicosAvancados
{
    internal class Dynamics
    {
        public static void Executar()
        {
            dynamic meuObjeto = "teste";
            meuObjeto = 3;

            meuObjeto++;
            Console.WriteLine(meuObjeto);

            dynamic aluno = new System.Dynamic.ExpandoObject();
            aluno.nome = "Patricio";
            aluno.idade = 20;
            aluno.aprovado = true;
            Console.WriteLine($"Nome:{aluno.nome}, Idade: {aluno.idade}, Situação: {(aluno.aprovado == true ? "Aprovado":"Reprovado")}");
        }
    }
}
