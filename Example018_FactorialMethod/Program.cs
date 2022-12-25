// метод, который принимает число N
// и вычисляет его факториал

double Factorial(int N)
{
  if(N == 1) return(1);
  else return N * Factorial(N - 1);
}
Console.WriteLine(Factorial(5));
Console.WriteLine();

for (int i = 1; i < 40; i++)
{
  Console.WriteLine($"{i}! = {Factorial(i)}");
}