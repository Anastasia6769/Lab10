// // foreach по строке
// string subject = "Программирование";

// foreach (char letter in subject)
// {
//     Console.WriteLine(letter);
// }
// Console.WriteLine("Количество букв:" + subject.Length);
// //Массив и foreach
// int[] grades = { 4, 5, 3, 5, 4 };
// int sum = 0;
// foreach (int grade in grades)
// {
//     Console.WriteLine(grade);
//     sum += grade;
// }
// double average = (double)sum / grades.Length;
// Console.WriteLine("Сумма оценок:"+ sum);
// Console.WriteLine("Средний балл:" + average);
//Массив строк
// string[] students = { "Аня", "Ярослав", "Вика" };
// int count = 0;
// foreach (string student in students)
// {
//     Console.WriteLine(student);
//     count++;
// }
// Console.WriteLine("Количество учеников:" + count);
// Ограничение foreach
// int[] points = { 10, 20, 15 };

// for (int i = 0; i < points.Length; i++)
// {
//     points[i] = points[i] + 5;
// }
// for (int i = 0; i < points.Length; i++)
// {
//     Console.WriteLine(points[i]);
// }
// // Нумерация элементов вручную
// string[] students = { "Аня", "Борис", "Вика" };
// int number = 1;

// foreach (string student in students)
// {
//     Console.WriteLine($"{number}.{student}");
//     number++;
// }
//Самостоятельные задания ★
//Задача А
// int[] numbers = { 4, 5, 3, 5, 4 };
// int sum = 0;
// foreach (int number in numbers)
// {
//     Console.WriteLine(number);
//     sum += number;
// }
// Console.WriteLine("Сумма:" + sum);
// //Задача Б
// // string[] days = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };
// // foreach (string day in days)
// // {
// //     Console.WriteLine(day + "!");
// // }
// //Индивидуальный вариант ★★
// Console.Write("Введите свою фамилию: ");
// string surname = Console.ReadLine()!.Trim();
// if (string.IsNullOrEmpty(surname)) {
// Console.WriteLine("Фамилия не введена. Завершение работы.");
// return;
// }
// Random rnd = new(surname.GetHashCode() + DateTime.Now.DayOfYear);
// var assigned = Enumerable.Range(1, 10)
// .OrderBy(_ => rnd.Next())
// .Take(2)
// .OrderBy(x => x)
// .ToList();
// Console.WriteLine($"Задачи: №{assigned[0]} и №{assigned[1]}");
// //Вариант 8
string word = "Программирование";
for (int i = word.Length - 1; i >= 0; i--)
{
    Console.Write(word[i]);
}
Console.WriteLine();
// //Вариант 10
string[] days = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };
int weekendCount = 0;
foreach (string day in days)
{
    if (day == "суббота" || day == "воскресенье")
    {
        weekendCount++;
    }
}
Console.WriteLine($"Количество выходных дней:{weekendCount}");
