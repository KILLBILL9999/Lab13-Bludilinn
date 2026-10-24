// PrintHeader();
// PrintHeader();
// Console.WriteLine("Основная часть программы");
// PrintFooter();

// void PrintHeader() {
//     Console.WriteLine("^_^");
//     Console.WriteLine("Лабораторная работа №13");
//     Console.WriteLine("0_0");
// }

// void PrintFooter() {
//     Console.WriteLine(">_<");
//     Console.WriteLine("   Конец программы");
//     Console.WriteLine("X_X");
// }

// void PrintData() {
//     Console.WriteLine(">_>");
//     Console.WriteLine("Дата формирования отчёта");
//     Console.WriteLine("X_0");
// }
// PrintData();


// void PrintStudentCard(string name, int age, string group) {
//     Console.WriteLine($"Студент: {name}, возраст: {age},номер группы: {group}");
// }
// PrintStudentCard("Егор", 18,"ISP251");
// PrintStudentCard("Валерия", 17,"ISP252");

// double CalculateScholarship(double baseAmount, double bonusPercent)
// {
//     return baseAmount + baseAmount * bonusPercent / 100;
// }

// bool IsEligibleForBonus(double averageGrade)
// {
//     return averageGrade >= 4.5;
// }

// double averageGrade = 4.7;

// if (IsEligibleForBonus(averageGrade))
// {
//     double result = CalculateScholarship(2000, 15);
//     Console.WriteLine($"Средний балл: {averageGrade}. Студент получает надбавку.");
//     Console.WriteLine($"Стипендия: {result}");
// }
// else
// {
//     double result = CalculateScholarship(2000, 0);
//     Console.WriteLine($"Средний балл: {averageGrade}. Надбавка не положена.");
//     Console.WriteLine($"Стипендия: {result}");
// }

// double CalculateAverageGrade(int[] grades)
// {
//     int sum = 0;
//     foreach (int grade in grades)
//     {
//         sum += grade;
//     }
//     return (double)sum / grades.Length;
// }

// int CountFives(int[] grades)
// {
//     int count = 0;
//     foreach (int grade in grades)
//     {
//         if (grade == 5)
//         {
//             count++;
//         }
//     }
//     return count;
// }

// int[] grades = { 5, 4, 5, 3, 5, 4, 5 };

// double average = CalculateAverageGrade(grades);
// int fives = CountFives(grades);

// Console.WriteLine($"Средний балл: {average}");
// Console.WriteLine($"Количество пятёрок: {fives}");


// void PrintPerson(string name, int age)
// {
//     Console.WriteLine($"Имя: {name}, возраст: {age}");
// }

// PrintPerson("Ярослав", 19);
// PrintPerson("Дмитрий", 20);
// PrintPerson("Валерия", 18);

int FindMax(int[] numbers)
{
    int max = numbers[0];
    foreach (int number in numbers)
    {
        if (number > max)
            max = number;
    }
    return max;
}

int[] values = { 10, 25, 7, 42, 18 };
int maxValue = FindMax(values);
Console.WriteLine($"Максимальное число: {maxValue}");