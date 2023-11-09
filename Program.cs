Console.Write("A sequência de Fibonacci irá até: ");

int length;
if (!int.TryParse(Console.ReadLine(), out length))
    throw new Exception("Valor inválido");

int antecessor = 0;
int atual = 1;
Console.WriteLine(antecessor);
Console.WriteLine(atual);
for (int i = 1; i <= (length - 2); i++)
{
    int proximo = antecessor + atual;
    antecessor = atual;
    atual = proximo;

    Console.WriteLine(proximo);
}