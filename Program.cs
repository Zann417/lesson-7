using System;

class CreditCard
{
    private string номерСчета;
    private decimal текущаяСумма;

    public CreditCard(string номерСчета, decimal начальнаяСумма)
    {
        this.номерСчета = номерСчета;
        this.текущаяСумма = начальнаяСумма;
    }

    public void Пополнить(decimal сумма)
    {
        текущаяСумма += сумма;
    }

    public void Снять(decimal сумма)
    {
        if (сумма <= текущаяСумма)
        {
            текущаяСумма -= сумма;
        }
        else
        {
            Console.WriteLine("Недостаточно средств на счете.");
        }
    }

    public void ВывестиИнформациюОКарте()
    {
        Console.WriteLine("Номер счета: " + номерСчета);
        Console.WriteLine("Текущая сумма: " + текущаяСумма);
    }
}

class Program
{
    static void Main(string[] args)
    {
        CreditCard карта1 = new CreditCard("123456789", 1000);
        CreditCard карта2 = new CreditCard("987654321", 500);
        CreditCard карта3 = new CreditCard("456789123", 2000);

        bool работаПрограммы = true;

        while (работаПрограммы)
        {
            Console.WriteLine("Выберите действие:");
            Console.WriteLine("1. Пополнить счет");
            Console.WriteLine("2. Снять со счета");
            Console.WriteLine("3. Вывести информацию о карте");
            Console.WriteLine("4. Выход");

            Console.Write("Введите ваш выбор: ");
            int выбор = Convert.ToInt32(Console.ReadLine());

            switch (выбор)
            {
                case 1:
                    Console.Write("Введите сумму для пополнения: ");
                    decimal суммаПополнения = Convert.ToDecimal(Console.ReadLine());
                    Console.Write("Введите номер карты (1, 2 или 3): ");
                    int номерКартыПополнения = Convert.ToInt32(Console.ReadLine());

                    if (номерКартыПополнения == 1)
                    {
                        карта1.Пополнить(суммаПополнения);
                    }
                    else if (номерКартыПополнения == 2)
                    {
                        карта2.Пополнить(суммаПополнения);
                    }
                    else if (номерКартыПополнения == 3)
                    {
                        карта3.Пополнить(суммаПополнения);
                    }
                    else
                    {
                        Console.WriteLine("Неправильный номер карты.");
                    }

                    break;

                case 2:
                    Console.Write("Введите сумму для снятия: ");
                    decimal суммаСнятия = Convert.ToDecimal(Console.ReadLine());
                    Console.Write("Введите номер карты (1, 2 или 3): ");
                    int номерКартыСнятия = Convert.ToInt32(Console.ReadLine());

                    if (номерКартыСнятия == 1)
                    {
                        карта1.Снять(суммаСнятия);
                    }
                    else if (номерКартыСнятия == 2)
                    {
                        карта2.Снять(суммаСнятия);
                    }
                    else if (номерКартыСнятия == 3)
                    {
                        карта3.Снять(суммаСнятия);
                    }
                    else
                    {
                        Console.WriteLine("Неправильный номер карты.");
                    }

                    break;

                case 3:
                    Console.Write("Введите номер карты (1, 2 или 3): ");
                    int номерКартыВывода = Convert.ToInt32(Console.ReadLine());

                    if (номерКартыВывода == 1)
                    {
                        карта1.ВывестиИнформациюОКарте();
                    }
                    else if (номерКартыВывода == 2)
                    {
                        карта2.ВывестиИнформациюОКарте();
                    }
                    else if (номерКартыВывода == 3)
                    {
                        карта3.ВывестиИнформациюОКарте();
                    }
                    else
                    {
                        Console.WriteLine("Неправильный номер карты.");
                    }

                    break;

                case 4:
                    работаПрограммы = false;
                    break;

                default:
                    Console.WriteLine("Неправильный выбор.");
                    break;
            }

            Console.WriteLine();
        }
    }
}