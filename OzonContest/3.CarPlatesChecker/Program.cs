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


string value = "A9PQ";

CheckLastChar(value);

void CheckLastChar(string str)
{
    if (char.IsDigit(str[str.Length - 1]))
    {
        Console.WriteLine("-");
    }
    else
    {
        Console.WriteLine(str);
    }
}