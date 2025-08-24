namespace Assignment01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "The ##enchanted## forest whispered secrets to the ##daring## young explorer, " +
                "Amelia. As she ventured deeper, the sunlight struggled to pierce the thick canopy of ancient trees. Strange ##creatures##" +
                " rustled in the undergrowth, their ##whispers## echoing through the air. A sense of ##wonder## filled Amelia, a mix of fear and" +
                " excitement. Suddenly, a glint of light caught her eye. A small, ##crystalline## stream flowed nearby, its water sparkling like diamonds. " +
                "As Amelia knelt to drink, a voice boomed from behind, 'Welcome, " +
                "traveler, to the heart of the ##enigmatic## forest!'";
            // removing ##
            str = str.Replace("##", "");

            // splitting the string into words
            string[] words = str.Split(" ");
            Console.WriteLine();
            Console.WriteLine($"Character Name: {words[10]}");

            //to uppercase
            Console.WriteLine(str.ToUpper());
            Console.WriteLine();
            //to lowercase
            Console.WriteLine(str.ToLower());
        }
    }
}
