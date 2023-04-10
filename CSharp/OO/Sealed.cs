namespace CSharp.OO
{
    sealed class SemFilho
    {
        public double ValorDaFortuna()
        {
            return 1_407_033.64;
        }
    }

    //class SouFilho : SemFilho { } Não é possível herdar de classes seladas

    class Avo
    {
        public virtual bool HonrarNomeFamilia()
        {
            return true;
        }
    }

    class Pai : Avo
    {
        public sealed override bool HonrarNomeFamilia()
        {
            return true;
        }
    }

    class FilhoRebelde : Pai
    {
        //public override bool HonrarNomeFamilia() Não é possível sobrescrever um método selado
        //{
        //    return false;
        //}
    }   
    internal class Sealed
    {
        public static void Executar()
        {
            SemFilho semFilho = new SemFilho();
            Console.WriteLine(semFilho.ValorDaFortuna());

            FilhoRebelde filho = new FilhoRebelde();
            Console.WriteLine(filho.HonrarNomeFamilia());

        }
    }
}
