internal class Program
{
    private static void Main(string[] args)
    {
        // Объявление необходимых переменных
        bool firstQueueIsPart = true, secondQueueIsPart = true;
        Queue<int> firstQueue = new Queue<int>(new[] { 1, 2, 3, 4 });
        Queue<int> secondQueue = new Queue<int>(new[] { 1, 2, 5, 4 });

        // Вывод очередей в консоль
        Console.Write("Первая очередь: ");
        foreach (int item in firstQueue) { Console.Write(item + " "); }
        Console.Write("\nВторая очередь: ");
        foreach (int item in secondQueue) { Console.Write(item + " "); }

        // Проверка очередей на причастность к друг другу
        foreach (int item in firstQueue) { if (!secondQueue.Contains(item)) { firstQueueIsPart = false; break; } }
        foreach (int item in secondQueue) { if (!firstQueue.Contains(item)) { secondQueueIsPart = false; break; } }

        // Вывод результата в консоль
        if (firstQueueIsPart && !secondQueueIsPart) Console.WriteLine("\n\nПервая очередь является частью второй");
        if (secondQueueIsPart && !firstQueueIsPart) Console.WriteLine("\n\nВторая очередь является частью первой");
        if (firstQueueIsPart && secondQueueIsPart) Console.WriteLine("\n\nОчереди равны");
        if (!firstQueueIsPart && !secondQueueIsPart) Console.WriteLine("\n\nНи одна из очередей не является частью другой");
    }
}