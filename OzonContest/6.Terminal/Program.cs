//Пример теста 1
//Входные данные

//4
//otLLLrRuEe256LLLN
//LRLUUDE
//itisatest
//abNcdLLLeUfNxNx

//Выходные данные

//route
//256
//-

//-
//itisatest
//-
//af
//x
//xb
//ecd
//-


//L - MoveLeft
//R - MoveRight
//U - MoveUp
//D - MoveDown
//B - MoveStart
//E - MoveEnd
//N - NewLine

int amount = int.Parse(Console.ReadLine());

for (var setIndex = 0; setIndex < amount; setIndex++)
{
    string input = Console.ReadLine();
    Terminal terminal = new Terminal();

    foreach (var charInput in input)
    {
        switch (charInput)
        {
            case 'L':
                terminal.MoveLeft();
                break;
            case 'R':
                terminal.MoveRight();
                break;
            case 'U':
                terminal.MoveUp();
                break;
            case 'D':
                terminal.MoveDown();
                break;
            case 'B':
                terminal.MoveStart();
                break;
            case 'E':
                terminal.MoveEnd();
                break;
            case 'N':
                terminal.NewLine();
                break;
            default:
                terminal.PlacementElement(charInput);
                break;
        }
    }
    foreach (var item in terminal._scope)
    {
        Console.WriteLine(new string(item.ToArray()));
    }
    Console.WriteLine("-");
}

class Terminal
{
    public List<List<char>> _scope;
    private (int , int) _coordinates;

    public Terminal()
    {
        _scope = new List<List<char>>() { new List<char>() };
        _coordinates = (0, 0);
    }
    public void MoveLeft()
    {
        _coordinates.Item1 = Math.Max(0, _coordinates.Item1 - 1);
    }
    public void MoveRight()
    {
        _coordinates.Item1 = Math.Min(_scope[_coordinates.Item2].Count, _coordinates.Item1 + 1);
    }
    public void MoveUp()
    {
        _coordinates.Item2 = Math.Max(_coordinates.Item2 - 1, 0);
        _coordinates.Item1 = Math.Min(_coordinates.Item1, _scope[_coordinates.Item2].Count);
    }
    public void MoveDown()
    {
        _coordinates.Item2 = Math.Min(_scope.Count - 1, _coordinates.Item2 + 1);
        _coordinates.Item1 = Math.Min(_coordinates.Item1, _scope[_coordinates.Item2].Count);
    } 
    public void MoveStart()
    {
        _coordinates.Item1 = 0;
    }
    public void MoveEnd()
    {
        _coordinates.Item1 = _scope[_coordinates.Item2].Count;
    }
    public void NewLine()
    {
        var newLine = new List<char>();

        for (int k = _coordinates.Item1; k < _scope[_coordinates.Item2].Count; k++)
        {
            newLine.Add(_scope[_coordinates.Item2][k]);
        }

        _scope[_coordinates.Item2].RemoveRange(_coordinates.Item1, _scope[_coordinates.Item2].Count - _coordinates.Item1);
        _scope.Insert(_coordinates.Item2 + 1, newLine);
        _coordinates.Item1 = 0;
        _coordinates.Item2 += 1;
    }
    public void PlacementElement(char charInput)
    {
        _scope[_coordinates.Item2].Insert(_coordinates.Item1, charInput);
        _coordinates.Item1++;
    }
}