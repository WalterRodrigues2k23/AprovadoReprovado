using System;
using System.Collections.Generic;

namespace ExercicioAprovadoReprovado
{
    internal class Aluno
    {
        public string Nome;
        public double Nota1, Nota2, Nota3;

        public double SomaNotas()
        {
            return (Nota1 + Nota2 + Nota3) / 100;
        }
        public double NotaResta()
        {
            return (60.00 - SomaNotas());
        }
    }
}
