namespace Letter_Value_Sum
{
    internal class Alphabet
    {
        //A dictionary to store the alphabet and their corresponding values - capital letters are counted as the same value as lowercase letters
        private static readonly Dictionary<char, int> _alphabet = new Dictionary<char, int>()
        {
            {'a', 1},
            {'b', 2},
            {'c', 3},
            {'d', 4},
            {'e', 5},
            {'f', 6},
            {'g', 7},
            {'h', 8},
            {'i', 9},
            {'j', 10},
            {'k', 11},
            {'l', 12},
            {'m', 13},
            {'n', 14},
            {'o', 15},
            {'p', 16},
            {'q', 17},
            {'r', 18},
            {'s', 19},
            {'t', 20},
            {'u', 21},
            {'v', 22},
            {'w', 23},
            {'x', 24},
            {'y', 25},
            {'z', 26}
        };

        public static int GetLetterValue(char letter)
        {
            //Return the value of the letter if it is in the dictionary, otherwise return 0
            return _alphabet.ContainsKey(letter) ? _alphabet[letter] : 0;
        }
    }
}
