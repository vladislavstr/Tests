//Входные данные

//5
//2 1 3 1 2 3 1 1 4 2
//1 1 1 2 2 2 3 3 3 4
//1 1 1 1 2 2 2 3 3 4
//4 3 3 2 2 2 1 1 1 1
//4 4 4 4 4 4 4 4 4 4
//Выходные данные

//YES
//NO
//YES
//YES
//NO


int amount = int.Parse(Console.ReadLine());
for (int i = 0; i < amount; i++)
{
    string input = Console.ReadLine();
    int[] array = Array.ConvertAll(input.Split(), int.Parse);
    Console.WriteLine(ContainsDuplicate(array));
}
string ContainsDuplicate(int[] array)
{
    Dictionary<int, int> counts = new Dictionary<int, int>()
    {
        { 1, 0},
        { 2, 0},
        { 3, 0},
        { 4, 0}
    };
    foreach (int element in array)
    {
        counts[element]++;
    }
    if (counts[1] == 4 && counts[2] == 3 && counts[3] == 2 && counts[4] == 1)
    {
        return "YES";

    }
    else
    {
        return "NO";
    }

}
