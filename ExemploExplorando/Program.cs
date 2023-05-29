using ExemploExplorando.Models;

Pessoa p1 = new Pessoa("Vitor", "Góes");
Pessoa p2 = new Pessoa("Julia", "Rodrigues");

Curso cursoPt = new Curso();
cursoPt.Nome = "Curso de Português";
cursoPt.Alunos = new List<Pessoa>();  // Instância de lista

cursoPt.AdicionarAluno(p1);
cursoPt.AdicionarAluno(p2);
cursoPt.ListarAlunos();