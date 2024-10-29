namespace Simulator
{
        internal class Creature
    {
        private int level = 1;
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
        public int Level
        {
            get => level;
            init
            {
                if (value > 10)
                {
                    value = 10;
                    
                }
                if (value <= 0)
                {
                    value = 1;
                }


                level = value;
            }
        }
        public Creature() { }
        public Creature(string name, int level = 1)
        {
            Name = name;
            Level = level >= 1 ? level : 1;
        }

        public void SayHi()
        {
            Console.WriteLine($"Hi, I'm {Name}, my level is {Level}.");
        }
        public void Upgrade()
        {
            if (level == 10)
            {
                level = 10;
            }
            else
            {
                level += 1;
            }
        }
        public string Info => $"{Name} [{Level}]";
    }
}