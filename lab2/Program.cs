internal class Program
{
    private static void Main(string[] args)
    {
        // Исходный стек и добавление в него элементов
        Stack<int> stack = new Stack<int>();
        stack.Push(53456);
        stack.Push(95864);
        stack.Push(99999);
        stack.Push(13377);
        stack.Push(14888);

        // Вывод исходного стека в консоль
        Console.WriteLine("Исходный стек:");
        foreach (int item in stack) { Console.WriteLine(item); }

        // Дополнительные необходимые переменные
        int elementWithMaxDigitSum = stack.Peek();
        int maxDigitSum = DigitSum(elementWithMaxDigitSum);
        Stack<int> tempStack = new Stack<int>(); // Промежуточный стек, где будут храниться элементы из первого стека

        // Извлекаем первые элементы из стека, проверяем по условию и добавляем в промежуточный
        while (stack.Count > 0)
        {
            int element = stack.Pop();
            int digitSum = DigitSum(element);

            if (digitSum > maxDigitSum) { maxDigitSum = digitSum; elementWithMaxDigitSum = element; }

            tempStack.Push(element);
        }

        // Возвращаем в стек все элементы кроме искомого
        while (tempStack.Count > 0)
        {
            int element = tempStack.Pop();
            if (element != elementWithMaxDigitSum) { stack.Push(element); }
        }

        // Вывод результата
        Console.WriteLine($"\nЭлемент с максимальной суммой цифр: {elementWithMaxDigitSum}");
        Console.WriteLine("\nСтек после обработки: ");
        foreach (int item in stack) { Console.WriteLine(item); }
    }

    // Алгоритм расчёта суммы цифр числа
    private static int DigitSum(int number)
    {
        int sum = 0;
        while (number > 0)
        {
            sum += number % 10;
            number /= 10;
        }

        return sum;
    }
}