internal class Program
{
    private static void Main(string[] args)
    {
        Random rnd = new Random();
        int value = rnd.Next(1, 8);
        if (value == 1)
        {
            Console.WriteLine("Вы выйграли Перо!");
        }
        if (value == 2)
        {
            Console.WriteLine("Вы выйграли Ручку!");
        }
        if (value == 3)
        {
            Console.WriteLine("Вы выйграли Камень!");
        }
        if (value == 4)
        {
            Console.WriteLine("Вы выйграли Ключ от GTA5!");
        }
        if (value == 5)
        {
            Console.WriteLine("Вы выйграли Взлом вашего ПК!");
        }
        if (value == 6)
        {
            Console.WriteLine("Вы выйграли Оценку 2 в журнал!");
        }
        if (value == 7)
        {
            Console.WriteLine("Вы выйграли Отключние интернета!");
        }
        if (value == 8)
        {
            Console.WriteLine("Вы выйграли Новый маркер!");
        }
    }
}