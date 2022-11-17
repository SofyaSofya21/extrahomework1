// 2. Есть программа с бесконечным циклом. 
// Есть команды для пользователяс 

string command = "0";
string password = "0";
string name = "Вы еще не ввели имя того, на кого лает маленькая собачка. Она лает просто так.";
bool correctCommand = false;
string passwordInput = "0";


Console.WriteLine("Cейчас начнется программа. Если Вы не будете знать, что делать, напишите Help");
Console.WriteLine();
Console.WriteLine("Что говорит маленькая собачка, когда видит большую собаку?");

while (correctCommand != true)
{
    Console.WriteLine("ГАВ! ГАВ! ГАВ! ГАВ! ГАВ! ГАВ! ГАВ! ГАВ!");
    command = Console.ReadLine();
    if (command == "Help")
    {
        Console.WriteLine("Доступные команды: ");
        Console.WriteLine("Help - вывести все доступные команды на экран");
        Console.WriteLine("Exit - остановить этот лай");
        Console.WriteLine("SetName - задать имя, на кого гавкать");
        Console.WriteLine("SetPassword - установить пароль на вывод заданного имени");
        Console.WriteLine("WriteName - показать имя, если пароль введен корректно");
    }
    else if (command == "Exit")
    {
        break;
    }
    else if (command == "SetName")
    {
        Console.WriteLine("Введите имя, на кого лает маленькая собачка");
        name = Console.ReadLine();
    }
    else if (command == "SetPassword")
    {
        Console.WriteLine("Введите пароль, чтобы защитить просмотр имени того, на кого лает маленькая собачка");
        password = Console.ReadLine();
    }
    else if (command == "WriteName")
    {
        if (name == "Вы еще не ввели имя того, на кого лает маленькая собачка. Она лает просто так.")
        {
            Console.WriteLine(name);
        }
        else if (password == "0")
        {
            Console.WriteLine($"Я гавкаю на того, кого зовут {name}!");
        }
        else if (password != "0")
        {
            Console.WriteLine("Введите пароль");
            int count = 0;
            int tries = 3; //количетво попыток для ввода пароля
            int tryNumber = 0;
            while (count < tries)
            {
                passwordInput = Console.ReadLine();
                count++;
                tryNumber = tries - count;
                if (passwordInput == password)
                {
                    Console.WriteLine($"Я гавкаю на того, кого зовут {name}!");
                    break;
                }
                else if (passwordInput != password && tryNumber != 0)
                {
                    Console.WriteLine($"Вы ввели неправильный пароль. Количество оставшихся попыток: {tryNumber}. Введите пароль еще раз");
                }
                else
                {
                    Console.WriteLine($"Вы ввели неправильный пароль и попыток больше нет. Я не покажу имя, на кого лает маленькая собачка.");
                }
            }
        }
    }
}
