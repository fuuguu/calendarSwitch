using System.Runtime;

internal class Program
{
    private static void Main(string[] args)
    {
        string dayOfWeek;
        Console.Write("Введите день недели: ");
        dayOfWeek = Console.ReadLine();
        switch (dayOfWeek)
        {
            case "понедельник":
                Console.WriteLine("День тяжелый. Много работы.");
                    break;
            case "вторник":
                Console.WriteLine("Сегодня можно расслабиться и заняться своими делами, а также неплохо выспаться.");
                break;
            case "среда":
                Console.WriteLine("Сегодня придется поднапрячься и постараться выполнить все задания.");
                break;
            case "четверг":
                Console.WriteLine("Сегодня много работы, но задания несложные, так что просто нужно оставаться внимательным.");
                break;
            case "пятница":
                Console.WriteLine("День перед выходными. Нужно постараться и выложиться на все 100 чтобы следующие два дня спокойно" +
                    "хать");
                break;
            case "суббота":
            case "воскресенье":
                Console.WriteLine("Выходной день. Занимаемся своими делами, никому не отвечаем по работе, ведь это наше законное время для" +
                    " чилла.");
                break;
            default:
                Console.WriteLine("Такого дня недели я не знаю.");
                break;
        }
    }
}