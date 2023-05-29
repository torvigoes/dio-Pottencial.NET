using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Pessoa
    {
        // Construtor
        public Pessoa()
        {

        }
        public Pessoa(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;  // Propriedades recebendo o valor dos parâmetros
        }

        // Propriedades
        private string _nome;
        private int _idade;
        public string Sobrenome { get; set; }
        public string NomeCompleto => $"{Nome} {Sobrenome.ToUpper()}"; // Propriedade somente leitura, apenas o get

        // Encapsulamento
        public string Nome // Propriedade
        {
            get => _nome.ToUpper(); // O sinal representa um body expression
            set
            {
                if(value == "")
                {
                    throw new ArgumentException("O nome não pode ser vazio");
                }

                _nome = value;
            }
        }

        public int Idade // Propriedade
        {
            get => _idade;
            set
            {
                if(value < 0)
                {
                    throw new ArgumentException("A idade não pode ser menor que zero");
                }
                _idade = value;
            }
        }

        // Métodos
        public void Apresentar() 
        {
            Console.WriteLine($"Nome: {NomeCompleto}, Idade: {Idade}");
        }
    }
}