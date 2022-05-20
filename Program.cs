Console.Clear();

double nrPrincipal, contador, produto;

Console.Write("Escreva um número qualquer: ");
nrPrincipal = Convert.ToDouble(Console.ReadLine()!);

contador = -1;

Console.WriteLine($"A tabuada do número {nrPrincipal} é: ");

while (contador++ < 10)
{    
    produto = nrPrincipal * contador;
    Console.WriteLine($"{nrPrincipal} x {contador} = {produto}");
}
return;