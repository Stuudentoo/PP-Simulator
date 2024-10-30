namespace Simulator;

public class Creature
{
    // Properties
    private string name = "Unknown";
    public string Name 
    {
        get => name;
        init
       {
    value = value.Trim();
    string a = value.Trim();
    string b = "";
    int counter = 0;
    for (int i = 0; i < a.Length; i++)
    {
        if (a[i] == ' ')
        {
            counter++;
        }
        if (a[i] != ' ')
        {
            counter = 0;
        }
        if (counter <= 1)
        {
            b += a[i];
        }
        value = b;
    }
    if (25 >= value.Length && value.Length >= 3)
    {
        name = value;
    }
    if (value.Length < 3)
    {

        for (int i = 0; i <= 4 - value.Length; i++)
        {
            value += "#";
        }
    name = value;
    }
    if (value.Length > 25)
    {
        string c = "";
        for (int i = 0; i < 25; i++)
        {
            c += value[i];
        }
        value = c.Trim();
        if (value.Length >= 3)
        {
            name = value;
        }
        if (value.Length >= 0 && value.Length < 3)
        {

            for (int i = 0; i <= 3 - value.Length;)
            {
                value += "#";
                i++;
            }
        name = value;
        
        }
    }
    name = char.ToUpper(name[0]) + name.Substring(1);
}
    }


    private int level = 1; // Fix ????
    public int Level
    {
        get => level;
        init
        {
            if (value < 1)
            {
                value = 1;
            }

            else if (value > 10)
            {
                value = 10;
            }

            level = value;
        }
    }


    // Constructors
    public Creature(string name, int level = 1)
    {
        Name = name;
        Level = level;
    }

    public Creature() { }


    // Methods
    public void SayHi() => Console.WriteLine($"Hi, I'm {Name}, my level is {Level}.");

    public string Info => $"{Name} [{Level}]";

    public void Upgrade()
    {
        if (level < 10)
        {
            level++;
        }
    }

    // Takes one parameter (Up, Right, Down, Left)
    public void Go(Direction direction)
    {
        Console.WriteLine($"{Name} goes {direction.ToString().ToLower()}.");
    }


    // Takes an array of parameters
    public void Go(Direction[] directions)
    {
        foreach (var direction in directions)
        {
            Go(direction);
        }
    }

    // Takes a string of parameters
    public void Go(string directions)
    {
        Direction[] parsedDirections = DirectionParser.Parse(directions);
        Go(parsedDirections);
    }
}