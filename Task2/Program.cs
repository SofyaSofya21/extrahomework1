// 2. Есть программа с бесконечным циклом. 
// Когда пользователь вводит exit программа заканчивается

string signal = "0";
string correctSignal = "exit";

Console.WriteLine("Что говорит маленькая собачка, когда видит большую собаку?");

while(signal != correctSignal)
{
    Console.WriteLine("ГАВ! ГАВ! ГАВ! ГАВ! ГАВ! ГАВ! ГАВ! ГАВ!");
    signal = Console.ReadLine();
}