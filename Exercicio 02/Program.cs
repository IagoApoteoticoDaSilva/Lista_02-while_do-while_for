/*
 * 2. Um usuário quer calcular suas despesas mensais. O exercício consiste em solicitar ao usuário que insira suas despesas até que ele digite um valor negativo, sinalizando o fim da entrada. O aluno deve somar as despesas e apresentar o total, utilizando while, do while e for.
 * 
 */



double despesas; //digitado pelo usuario
double Base = 0; //vai jogar a variavel de cima pra cá, para realizar a soma

//^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^WHILE^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

Console.WriteLine("Digite suas despesas mensais (encerre com algum valor negativo)");

while (true)
{
   despesas = Convert.ToDouble(Console.ReadLine());
   if (despesas < 0) break;
    Base += despesas;
}
Console.WriteLine($"Total de despesas é: {Base}");

//^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^DO WHILE^^^^^^^^^^^^^^^^^^^^^^^^^^^^

do
{
    Console.WriteLine("Digite suas despesas mensais (encerre com algum valor negativo)");
    despesas = Convert.ToDouble(Console.ReadLine());
    if (despesas < 0) break;
    Base += despesas;
} while (despesas > 0);
Console.WriteLine($"Total de despesa é: {Base}");

//^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^FOR^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

for (; ; )
{
    Console.WriteLine("Digite suas despesas mensais (encerre com algum valor negativo)");
    despesas = Convert.ToDouble(Console.ReadLine());
    if (despesas < 0) break;
    Base += despesas;
}
Console.WriteLine($"Total de despesas: {Base}");

