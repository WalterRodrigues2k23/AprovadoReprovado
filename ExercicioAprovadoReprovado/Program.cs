using System.Globalization;

namespace ExercicioAprovadoReprovado
{
    class AprovadoReprovado
    {
        static void Main(string[] args)
        {
            
            Aluno aluno = new Aluno();

            Console.Write("Digite o nome do Aluno: ");
            aluno.Nome = Console.ReadLine();

            Console.WriteLine("Digite as três notas do aluno: ");
            aluno.Nota1 = double.Parse(Console.ReadLine());
            aluno.Nota2 = double.Parse(Console.ReadLine());
            aluno.Nota3 = double.Parse(Console.ReadLine());

            Console.WriteLine("NOTA FINAL = " + aluno.SomaNotas().ToString("F2", CultureInfo.InvariantCulture));
            if (aluno.SomaNotas() >= 60.00){
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTAM " + aluno.NotaResta().ToString("F2", CultureInfo.InvariantCulture) + " PONTOS");
            }
        }        

    }
}
