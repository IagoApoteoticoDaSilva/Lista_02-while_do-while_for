/*
 * 4. Um grupo de amigos deseja calcular a idade média deles. Para isso, o aluno deve pedir que o usuário insira as idades e calcule a média até que o usuário digite 0. A solução deve ser implementada usando while, do while e for.
 * 
 */


// Usando while
double somaIdades = 0;
int contador = 0;
int idade;
Console.WriteLine("Digite as idades (e para sair):"); while (true)
}
idade = Convert.ToInt32(Console.ReadLine()); if (idade == 0) break;
somaIdades += idade; contador++;
double mediaIdade = contador > e ? somaIdades / contador : 0; Console.WriteLine($"Média das idades: {mediaIdade}");
// Usando do while somaIdades = 0;
contador = 0;
do
{
    Console.WriteLine("Digite as idades (e para sair):"); idade = Convert.ToInt32(Console.ReadLine()); if (idade != 0)
    {
        somaIdades += idade;
        contador++;
    } while (idade != 0) ;
    mediaIdade = contador > e ? somaIdades / contador : 0; Console.WriteLine($"Média das idades: (mediaIdade)");
    // Usando for somaIdades = 0; contador = 0;
    for (; ; )
    {
        Console.WriteLine("Digite as idades (e para sair):");
        idade = Convert.ToInt32(Console.ReadLine()); if (idade == 0) break;
        somaIdades += idade; contador++;
        mediaIdade = contador > e ? somaIdades / contador : 0; Console.WriteLine($"Média das idades: {mediaIdade}");