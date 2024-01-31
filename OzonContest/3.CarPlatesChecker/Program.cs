//Пример теста 1
//Входные данные

//6
//R48FAO00OOO0OOA99OKA99OK
//R48FAO00OOO0OOA99OKA99O
//A9PQ
//A9PQA
//A99AAA99AAA99AAA99AA
//AP9QA

//Выходные данные

//R48FA O00OO O0OO A99OK A99OK
//-
//A9PQ
//-
//A99AA A99AA A99AA A99AA
//-

using System.Text;
using System.Text.RegularExpressions;

string snippet = @"\D{1}\d{1,2}\D{2}";

int amount = int.Parse(Console.ReadLine());

for (int i = 0; i < amount; i++)
{
    string input = Console.ReadLine();
    int len = input.Length;
    int stringBuilderCapacity = (int)(len * 1.5);

    if (char.IsDigit(input[len - 1]) || len < 4)
    {
        Console.WriteLine("-");
    }
    else
    {
        StringBuilder sbInput = new StringBuilder(input);
        StringBuilder sbOut = new StringBuilder("", stringBuilderCapacity);

        foreach (Match match in Regex.Matches(input, snippet))
        {
            sbOut.Append(match.Value + " ");
            sbInput.Replace(match.Value, "");
        }
        if (sbInput.Length > 0)
            Console.WriteLine("-");
        else
            Console.WriteLine(sbOut);
    }
}
