Console.Write("Введите номер дня недели: ");
int week = Convert.ToInt32(Console.ReadLine());

switch (week)
{
    case 1:
        Console.WriteLine(day.Понедельник);
        break;
    case 2:
        Console.WriteLine(day.Вторник);
        break;
    case 3:
        Console.WriteLine(day.Среда);
        break;
    case 4:
        Console.WriteLine(day.Четверг);
        break;
    case 5:
        Console.WriteLine(day.Пятница);
        break;
    case 6:
        Console.WriteLine(day.Суббота);
        break;
    case 7:
        Console.WriteLine(day.Вокресенье);
        break;
    default:
        Console.WriteLine("Такого дня нет");
        break;

}

enum day
{
    Понедельник,
    Вторник,
    Среда,
    Четверг,
    Пятница,
    Суббота,
    Вокресенье
}