
using System.Diagnostics;

void Asincronus(string taskNumber)
{
Stopwatch crono = Stopwatch.StartNew();
crono.Start();
Thread.Sleep(1000);
crono.Stop();
Console.WriteLine($"{taskNumber}: {crono.Elapsed}");
};

var task1 = new Task(() =>
{
    string task = "Task 1";
    Asincronus(task);
});

var task2 = new Task(() =>
{
    string task = "Task 2";
    Asincronus(task);
});

var task3 = new Task(() =>
{
    string task = "Task 3";
    Asincronus(task);
});

var task4 = new Task(() =>
{
    RandomAsync();
});

static async Task<string> RandomAsync()
{
    Stopwatch crono = Stopwatch.StartNew();
    crono.Start();
    var num = new Random().Next(1000);
    crono.Stop();
    
    var task = new Task<string>(()=> String.Concat(num, " calculado en: ", crono.Elapsed));
    task.Start();
    string result = await task;

    return result;
}
task1.Start();
task2.Start();
task3.Start();
task4.Start();