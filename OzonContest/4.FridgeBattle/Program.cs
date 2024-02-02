//Пример теста 1
//Входные данные

//4
//1
//>= 30
//6
//>= 18
//<= 23
//>= 20
//<= 27
//<= 21
//>= 28
//3
//<= 25
//>= 20
//>= 25
//3
//<= 15
//>= 30
//<= 24
//Выходные данные

//30

//18
//18
//20
//20
//20
//-1

//15
//20
//25

//15
//-1
//-1

int amount = int.Parse(Console.ReadLine());
for (int i = 0; i < amount; i++)
{
    int peopleAmount = int.Parse(Console.ReadLine());
    int[] rangeOfTemperature = { 15, 30 };

    for (int j = 0; j < peopleAmount; j++)
    {
        string inputTemperature = Console.ReadLine();
        int declaredTemperature = Int32.Parse(inputTemperature.Substring(2));
        string declaredSymbol = inputTemperature.Substring(0, 1);
        
        if (declaredSymbol == ">" && declaredTemperature >= rangeOfTemperature[0])
        {
            rangeOfTemperature[0] = declaredTemperature;
        }
        else if (declaredSymbol == "<" && declaredTemperature <= rangeOfTemperature[1])
        {
            rangeOfTemperature[1] = declaredTemperature;
        }
        
        if (rangeOfTemperature[0] <= rangeOfTemperature[1])
        {
            Console.WriteLine((int)rangeOfTemperature.Average());
        }
        else
        {
            Console.WriteLine("-1");
        }
    }
    Console.WriteLine();
}
