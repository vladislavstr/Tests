//Пример теста 1
//Входные данные

//7
//8
//7
//8
//1,7,1
//8
//1 - 5,1,7 - 7
//10
//1 - 5
//10
//1,2,3,4,5,6,8,9,10
//3
//1 - 2
//100
//1 - 2,3 - 7,10 - 20,100
//Выходные данные

//1-6,8
//2-6,8
//6,8
//6-10
//7
//3
//8-9,21-99

using var input = new StreamReader(Console.OpenStandardInput());
using var output = new StreamWriter(Console.OpenStandardOutput());

int amount = int.Parse(input.ReadLine());
for (int i = 0; i < amount; i++)
{
    var CountOfPages = int.Parse(input.ReadLine());
    HashSet<int> setOfPages = new HashSet<int>();

    for (int j = 1; j <= CountOfPages; j++)
    {
        setOfPages.Add(j);
    }

    using var inputNumberOfPages = new StreamReader(Console.OpenStandardInput());
    string[] NumberOfPages = inputNumberOfPages.ReadLine().Split(',');

    foreach (string item in NumberOfPages)
    {
        if (int.TryParse(item, out int number))
        {
            setOfPages.Remove(int.Parse(item));
        }
        else
        {
            int[] arrayOfPages = Array.ConvertAll(item.Split('-'), int.Parse);

            int intervalBeginning = arrayOfPages[0];
            int intervalEnding = arrayOfPages[1];

            for (int n = intervalBeginning; n <= intervalEnding; n++)
            {
                setOfPages.Remove(n);
            }
        }
    }

    int[] arrayOfHalfBakedPages = setOfPages.OrderBy(x => x).ToArray();
    int lengthOfHalfBakedPagesarray = arrayOfHalfBakedPages.Length;

    List<string> needToPrint = new List<string>();

    for (int k = 0; k < lengthOfHalfBakedPagesarray; k++)
    {
        if (k + 1 < lengthOfHalfBakedPagesarray && arrayOfHalfBakedPages[k + 1] - arrayOfHalfBakedPages[k] == 1)
        {
            int firstValue = arrayOfHalfBakedPages[k];
            while (k + 1 < lengthOfHalfBakedPagesarray && arrayOfHalfBakedPages[k + 1] - arrayOfHalfBakedPages[k] == 1)
            {
                k++;
            }
            int seccondValue = arrayOfHalfBakedPages[k];
            needToPrint.Add($"{firstValue}-{seccondValue}");
        }
        else
        {
            needToPrint.Add($"{arrayOfHalfBakedPages[k]}");
        }
    }

    output.WriteLine(string.Join(",", needToPrint.ToArray()));
}