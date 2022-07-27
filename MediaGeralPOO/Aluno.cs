﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaGeralPOO
{
    internal class Aluno
    {
        public string Nome { get; private set; } // atribuir sempre dentro da classe


        private double[] _notas;

        public double Media
        {
            get
            {
                return CalcularMedia();
            }
        }

        public Aluno(string nome, int provas)
        {
            Nome = nome;
            _notas = new double[provas];
        }

        public void InserirNotas()
        {
            for (var i = 0; i < _notas.Length; i++)
            {
                Console.Write("Nota #" + (i + 1) + ": ");
                _notas[i] = double.Parse(Console.ReadLine());
            }
        }
            private double CalcularMedia()
            {
                double total = 0;
                for(var i=0; i < _notas.Length; i++)
                {
                    total += _notas[i];
                    
                }
                return total / _notas.Length;
            }
        
    }
}
