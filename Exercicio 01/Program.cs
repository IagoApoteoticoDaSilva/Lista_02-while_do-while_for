/*
 * 1.Um funcionário deseja contar quantos dias de trabalho ele teve em um mês. Para isso, ele deve inserir os dias trabalhados (de 1 a 31) até que digite 0, que indica que terminou de informar os dias. O aluno deve implementar essa contagem utilizando as estruturas de repetição while, do while e for.
 *
 */


Console.WriteLine("Digite os dias trabalhaos (0 para sair)");

int diasTrabalhados = 0;
int dia;

//^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^WHILE^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

while (true) 
{
    dia = Convert.ToInt32(Console.ReadLine());
    if (dia == 0) break;
    diasTrabalhados++;
}
Console.WriteLine($"Total de dias trabalhados: {diasTrabalhados}");

//^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^DO WHILE^^^^^^^^^^^^^^^^^^^^^^^^^^^^

do
{
    Console.WriteLine("Digite os dias trbalhados (0 para sair)");
    dia = Convert.ToInt32(Console.ReadLine());
    if (dia != 0) diasTrabalhados++;
}   while (dia != 0);
Console.WriteLine($"Total de dias trabalhados: {diasTrabalhados}");

//^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^FOR^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

for (; ; )
{
    Console.WriteLine("Digite os dias trabalhados (0 para sair)");
    dia = Convert.ToInt32(Console.ReadLine());
    if (dia == 0) break;
    diasTrabalhados++;
}
Console.WriteLine($"Total de dias trabalhados: {diasTrabalhados}");


