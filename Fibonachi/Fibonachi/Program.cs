int n = 20; 
long[] fibonacci = new long[n];

fibonacci[0] = 0;
fibonacci[1] = 1;

for (int i = 2; i < n; i++)
{
    fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
}

Console.WriteLine("Первые 20 чисел Фибоначчи:");
for (int i = 0; i < n; i++)
{
    Console.WriteLine(fibonacci[i]);
}