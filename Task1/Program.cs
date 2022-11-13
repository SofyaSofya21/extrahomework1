// 1. В переменной string есть секретное сообщение, во второй есть пароль. 
// Пользователю программы даётся 3 попытки ввести пароль и увидеть секретное сообщение.

string message = "Ты невероятно замечательный человек!";
string correctPassword = "2112";
int count = 0;
int tries = 3;
string password = "0";

Console.WriteLine("Для Вас есть секретное сообщение. Введите пароль");

while(count<tries)
{
   password = Console.ReadLine();
   count++;
   if(password == correctPassword)
   {
        Console.WriteLine("Ура! Пароль корректен! Вот секретное сообщение: ");
        Console.Write(message);
   }
   else
   {
        if (count<tries)
        {
            Console.WriteLine($"Вы ввели некорректный пароль. Попробуйте еще раз. Количество оставшихся попыток: {tries-count}.");
        }
        else
        {
            Console.WriteLine("Вы потратили все попытки. Оставайтесь теперь без секретного сообщения. :(");
        }
   }
}

