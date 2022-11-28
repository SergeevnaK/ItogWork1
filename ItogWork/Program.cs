// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
//При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

int Schetchik(string[] mas) // метод для нахождения длины массива, предназначенного для записи
{
    int ind = 0;
    for (int i = 0; i < mas.Length; i++)
    {
        if (mas[i].Length <= 3)
        {
            ind++;
        }
    }
    return ind;
}

string[] Scaner(string[] mass, int count) // метод для поиска элементов длиною меньше 3, записи их в возвращаемый массив
{
    string[] result = new string[count];
    int index = 0;
    for (int i = 0; i < mass.Length; i++)
    {
        if (mass[i].Length <= 3)
        {
            result[index] = mass[i];
            index++;
        }
    }
    return result;
}

Console.WriteLine("Введите массив строк через пробел");
string[] mass = Console.ReadLine()!.Split(' ');

Console.WriteLine("Элементы не длинее 3 символов:");

for (int i = 0; i < Schetchik(mass); i++)
{
    Console.Write("{0} ", Scaner(mass, Schetchik(mass))[i]);
}
