/*
 * 3. Uma escola deseja saber quantos alunos foram aprovados em uma disciplina. O aluno deverá solicitar que o usuário insira as notas dos alunos (de 0 a 10) e, ao digitar -1, encerrará a entrada. Em seguida, deve contar quantos alunos tiveram nota maior ou igual a 6, utilizando as três estruturas de repetição.
 * 
 */

double notas; 
double alunosAprovados = 0;

//^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^WHILE^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

Console.WriteLine("Digite a nota do aluno, para encerrar digite valor negativo");

while (true)
{
    notas = Convert.ToDouble(Console.ReadLine());
    if (notas < 0) break;
    if (notas >= 6) alunosAprovados++;
}
Console.WriteLine($"total de alunos aprovados: {alunosAprovados}");

//^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^DO WHILE^^^^^^^^^^^^^^^^^^^^^^^^^^^^

alunosAprovados = 0;
do
{
    Console.WriteLine("Digite a nota do aluno, para encerrar digite valor negativo");
    notas = Convert.ToDouble(Console.ReadLine());
    if (notas >= 6 && notas != -1) alunosAprovados++;
} while (notas != -1);
Console.WriteLine($"Total de launos aprovados: {alunosAprovados}");

//^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^FOR^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

alunosAprovados = 0;

for (; ; )
{
    Console.WriteLine("Digite as notas dos alunos (digite -1 para sair):"); notas = Convert.ToDouble(Console.ReadLine());
    if (notas == -1) break;
    if (notas >= 6) alunosAprovados++;

}Console.WriteLine($"Total de alunos aprovados: {alunosAprovados}");

