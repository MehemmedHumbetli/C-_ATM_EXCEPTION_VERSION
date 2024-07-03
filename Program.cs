class Program
{
    class Dictionary
    {
        public Dictionary<string, string> translate = new Dictionary<string, string>();

        public string this[string word]
        {
            get
            {
                try
                {
                    return translate[word];
                }
                catch (KeyNotFoundException)
                {
                    return "Word could not found";
                }
            }
            set
            {
                translate[word] = value;
            }
        }
    }
    static void Main(string[] args)
    {
        Dictionary dictonary = new Dictionary();

        dictonary["masin"] = "car";

        Console.WriteLine($"masin : {dictonary["masin"]}");
    }
}