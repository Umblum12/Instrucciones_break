//Break
for (int id = 0; id <= 10; id++)
{
    Thread.Sleep(800);
    Console.WriteLine(id);
    if (id == 5)
    {
        break;
    }
}
Console.ReadKey(true);