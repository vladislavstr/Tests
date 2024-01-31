//Пример теста 1
//Входные данные

//10
//10 9 2022
//21 9 2022
//29 2 2022
//31 2 2022
//29 2 2000
//29 2 2100
//31 11 1999
//31 12 1999
//29 2 2024
//29 2 2023

//Выходные данные

//YES
//YES
//NO
//NO
//YES
//NO
//NO
//YES
//YES
//NO

int amount = int.Parse(Console.ReadLine());
for (int i = 0; i < amount; i++)
{
    string dateInput = Console.ReadLine();

    bool result = DateTime.TryParse(dateInput, out var number);
    if (result == true)
    {
        Console.WriteLine("YES");
    }
    else
        Console.WriteLine("NO");
}