using System.Diagnostics;

int[] arr;
Console.WriteLine("Enter number of elements: ");
int N = Convert.ToInt32(Console.ReadLine());

arr = new int[N];

for(int i = 0; i<N; i++)
{
    arr[i] = 1;
}
Stopwatch crono = new Stopwatch();
crono.Start();

for(int j = 0; j < N; j++)
{
    for(int k = N-1; k > 0; k--)
    {
        arr[k] = j+k;
    }
}
crono.Stop();
Console.WriteLine($"The time elapsed is: {crono.Elapsed}");