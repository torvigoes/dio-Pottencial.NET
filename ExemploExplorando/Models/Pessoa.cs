using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Pessoa
    {
        // Propriedades
        private string _nome;

        // Encapsulamento
        public string Nome 
        {
            get
            {
                return _nome.ToUpper();
            }

            set
            {
                if(value == "")
                {
                    throw new ArgumentException("O nome não pode ser vazio");
                }

                _nome = value;
            }
        }

        public int Idade {get; set;}

        public void Apresentar()
        {
            Console.WriteLine($"Nome: {Nome}, Idade: {Idade}");
        }
    }
}