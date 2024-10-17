internal class Program
{
    // Пол работника через перечисление
    enum Gender
    {
        Male,
        Female
    }

    // Структура работника
    struct Employee
    {
        public string secondName;
        public int salary;
        public Gender gender;
    }

    private static void Main(string[] args)
    {
        // Массив с работниками
        Employee[] employees = new Employee[] {
            new Employee{ secondName = "Авлияев", salary = 50_000, gender = Gender.Male },
            new Employee{ secondName = "Григорьев", salary = 5_885_620, gender = Gender.Male },
            new Employee{ secondName = "Бережной", salary = 250_000, gender = Gender.Male },
            new Employee{ secondName = "Пеньков", salary = 1_000_000, gender = Gender.Male },
            new Employee{ secondName = "Громова", salary = 45_000, gender = Gender.Female },
            new Employee{ secondName = "Салий", salary = 100_000, gender = Gender.Female },
            new Employee{ secondName = "Попова", salary = 450_000, gender = Gender.Female }
        };

        // Дополнительные переменные
        string maxEarningMaleSecondName = string.Empty, minEarningMaleSecondName = string.Empty, minEarningFemaleSecondName = string.Empty;
        int maxMaleSalary = int.MinValue, minMaleSalary = int.MaxValue, minFemaleSalary = int.MaxValue;

        // Поиск работников по условию
        foreach (Employee employee in employees)
        {
            if (employee.gender == Gender.Male)
            {
                if (employee.salary > maxMaleSalary)
                {
                    maxMaleSalary = employee.salary;
                    maxEarningMaleSecondName = employee.secondName;
                }

                if (employee.salary < minMaleSalary)
                {
                    minMaleSalary = employee.salary;
                    minEarningMaleSecondName = employee.secondName;
                }
            }
            else
            {
                if (employee.salary < minFemaleSalary)
                {
                    minFemaleSalary = employee.salary;
                    minEarningFemaleSecondName = employee.secondName;
                }
            }
        }

        // Вывод в консоль результата
        Console.WriteLine($"Фамилия мужчины с самой высокой зарплатой - {maxEarningMaleSecondName} ({maxMaleSalary})");
        Console.WriteLine($"Фамилия мужчины с самой низкой зарплатой - {minEarningMaleSecondName} ({minMaleSalary})");
        Console.WriteLine($"Фамилия женщины с самой низкой зарплатой - {minEarningFemaleSecondName} ({minFemaleSalary})");
    }
}
