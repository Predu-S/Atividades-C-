using Atvd03.Models;

Pessoa p1 = new Pessoa("Pedro", "Lucas");
Pessoa p2 = new Pessoa("João", "Silva");


Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Ingles";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);

cursoDeIngles.ListarALunos();

