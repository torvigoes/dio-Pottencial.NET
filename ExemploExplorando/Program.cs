using ExemploExplorando.Models;

Pessoa p1 = new Pessoa();
p1.Nome = "Vitor";
p1.Sobrenome = "Góes";

Pessoa p2 = new Pessoa();
p2.Nome = "Julia";
p2.Sobrenome = "Rodrigues";

Curso cursoPt = new Curso();
cursoPt.Nome = "Curso de Português";
cursoPt.Alunos = new List<Pessoa>();  // Instância de lista

cursoPt.AdicionarAluno(p1);
cursoPt.AdicionarAluno(p2);
cursoPt.ListarAlunos();