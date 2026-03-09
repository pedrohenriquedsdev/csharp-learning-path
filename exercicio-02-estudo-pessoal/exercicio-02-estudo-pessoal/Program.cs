// Ex 6.1 — Percorra os números de 1 a 20. Use continue para pular os pares e exibir apenas os ímpares.

for (int i = 1; i <= 20; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine($"Número par = {i}");
    }
    else
    {
        continue;
    }
}

Console.WriteLine("=====================");

// Ex 6.2 — Percorra os números de 1 a 100. Use break para parar assim que encontrar o primeiro número divisível por 7 e por 3 ao mesmo tempo.

for (int j = 1; j <= 100; j++)
{
    if (j % 7 == 0 && j % 3 == 0)
    {
        Console.WriteLine($"O numero divisel por 7 e 3 é = {j}");
    }
}