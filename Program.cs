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
int[] points = { 10, 20, 15 };

for (int i = 0; i < points.Length; i++)
{
    points[i] = points[i] + 5;
}
for (int i = 0; i < points.Length; i++)
{
    Console.WriteLine(points[i]);
}
// Нумерация элементов вручную
string[] students = { "Аня", "Борис", "Вика" };
int number = 1;

foreach(string student in students)
{
    Console.WriteLine($"{number}.{student}");
    number++;
}