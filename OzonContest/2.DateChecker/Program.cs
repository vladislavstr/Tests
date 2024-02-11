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

using var input = new StreamReader(Console.OpenStandardInput());
using var output = new StreamWriter(Console.OpenStandardOutput());

int amount = int.Parse(input.ReadLine());
for (int i = 0; i < amount; i++)
{
    string date = input.ReadLine();
    List<int> a = date.Split(' ').Select(x => int.Parse(x)).ToList();
    var d = a[0];
    var m = a[1];
    var y = a[2];
    bool isValid = d >= 1 && d <= 31 && m >= 1 && m <= 12 && y >= 1950 && y <= 2300;
    if (isValid)
    {
        if (m == 2)
        {
            if ((y % 4 == 0 && y % 100 != 0) || (y % 400 == 0))
            {
                isValid = d >= 1 && d <= 29;
            }
            else
            {
                isValid = d >= 1 && d <= 28;
            }
        }
        else
        {
            if (m == 1 || m == 3 || m == 5 || m == 7 || m == 8 || m == 10 || m == 12)
            {
                isValid = d >= 1 && d <= 31;
            }
            else
            {
                isValid = d >= 1 && d <= 30;
            }
        }
    }

    output.WriteLine(isValid ? "YES" : "NO");
}