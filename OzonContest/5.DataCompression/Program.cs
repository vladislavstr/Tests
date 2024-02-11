//Пример теста 1
//Входные данные

//5
//9
//3 2 1 0 -1 0 6 6 7
//1
//1000
//7
//1 2 3 4 5 6 7
//7
//1 3 5 7 9 11 13
//11
//100 101 102 103 19 20 21 22 42 41 40
//Выходные данные

//8
//3 -4 0 0 6 0 6 1
//2
//1000 0
//2
//1 6
//14
//1 0 3 0 5 0 7 0 9 0 11 0 13 0
//6
//100 3 19 3 42 -2


int amount = int.Parse(Console.ReadLine());

for (int i = 0; i < amount; i++)
{
    int inputListLength = int.Parse(Console.ReadLine());
    string inputList = Console.ReadLine();

    int[] array = Array.ConvertAll(inputList.Split(), int.Parse);
    List<int> compressedList = new List<int>();
    int tmp = 0;

    for (int j = 0; j < inputListLength - 1; j++)
    {
        int firstValue = array[j];
        int seccondValue = array[j + 1];

        if (tmp == 0)
        {
            compressedList.Add(firstValue);
        }
        if (firstValue - seccondValue == 1 && tmp <= 0)
        {
            tmp--;
        }
        else if (firstValue - seccondValue == -1 && tmp >= 0)
        {
            tmp++;
        }
        else
        {
            compressedList.Add(tmp);
            tmp = 0;
        }
    }
    if (tmp != 0)
    {
        compressedList.Add(tmp);
    }
    else
    {
        compressedList.Add(array[inputListLength - 1]);
        compressedList.Add(tmp);
    }
    Console.WriteLine(compressedList.Count);
    Console.WriteLine(string.Join(" ", compressedList));
}