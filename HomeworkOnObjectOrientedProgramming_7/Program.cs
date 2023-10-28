using System;

namespace HomeworkOnObjectOrientedProgramming_7
{
    class Program
    {
        static void Main(string[] args)
        {
            var aCoder = new ACoder(); string str = aCoder.Encode("мама мыла раму"); Console.WriteLine(str); str = aCoder.Decode(str); Console.WriteLine(str);

            var bCoder = new BCoder();
            str = bCoder.Encode("мама мыла раму");
            Console.WriteLine(str);
            str = bCoder.Decode(str);
            Console.WriteLine(str);

        }
    }

    interface ICoder
    {
        string Encode(string line);
        string Decode(string line);
    }

    class ACoder : ICoder
    {

        char[] alphabet = ("абвгдеёжзийклмнопрстуфцхцчшщъыьэюя ").ToCharArray();


        public string Decode(string line)
        {
            char[] lettersFromString = line.ToCharArray();
            string newLine = "";
            foreach (char letter in lettersFromString)
            {
                newLine += decodingFindingReplacingLetter(letter);
            }
            return newLine;
        }

        public string Encode(string line)
        {
            char[] lettersFromString = line.ToCharArray();
            string newLine = "";
            foreach (char letter in lettersFromString)
            {
                newLine += encipheringFindingReplacingLetter(letter);
            }
            return newLine;
        }

        char encipheringFindingReplacingLetter(char letter)
        {
            int indexFoundLetter = -1;

            foreach (char currentLetter in alphabet)
            {
                indexFoundLetter++;
                if (letter == currentLetter)
                {
                    return encipheringReplacingLetter(letter, indexFoundLetter);
                }
            }
            return letter;
        }

        char encipheringReplacingLetter(char letter, int indexFoundLetter)
        {

            if ("я"[0] == letter) return alphabet[0];
            if (" "[0] == letter) return alphabet[34];
            return alphabet[indexFoundLetter + 1];
        }

        char decodingFindingReplacingLetter(char letter)
        {
            int indexFoundLetter = -1;

            foreach (char currentLetter in alphabet)
            {
                indexFoundLetter++;
                if (letter == currentLetter)
                {
                    return decodingReplacingLetter(letter, indexFoundLetter);
                }
            }
            return letter;
        }

        char decodingReplacingLetter(char letter, int indexFoundLetter)
        {
            if ("а"[0] == letter) return alphabet[32];

            if (" "[0] == letter) return alphabet[34];

            return alphabet[indexFoundLetter - 1];
        }
    }


    class BCoder : ICoder
    {
        char[] alphabet = ("абвгдеёжзийклмнопрстуфцхцчшщъыьэюя ").ToCharArray();


        public string Decode(string line)
        {
            char[] lettersFromString = line.ToCharArray();
            string newLine = "";
            foreach (char letter in lettersFromString)
            {
                newLine += decodingFindingReplacingLetter(letter);
            }
            return newLine;
        }

        public string Encode(string line)
        {
            char[] lettersFromString = line.ToCharArray();
            string newLine = "";
            foreach (char letter in lettersFromString)
            {
                newLine += encipheringFindingReplacingLetter(letter);
            }
            return newLine;
        }

        char encipheringFindingReplacingLetter(char letter)
        {
            int indexFoundLetter = -1;

            foreach (char currentLetter in alphabet)
            {
                indexFoundLetter++;
                if (letter == currentLetter)
                {
                    return encipheringReplacingLetter(letter, indexFoundLetter);
                }
            }
            return letter;
        }

        char encipheringReplacingLetter(char letter, int indexFoundLetter)
        {

            if (" "[0] == letter) return alphabet[34];

            indexFoundLetter = 33 - indexFoundLetter;
            return alphabet[indexFoundLetter];
        }

        char decodingFindingReplacingLetter(char letter)
        {
            int indexFoundLetter = -1;

            foreach (char currentLetter in alphabet)
            {
                indexFoundLetter++;
                if (letter == currentLetter)
                {
                    return decodingReplacingLetter(letter, indexFoundLetter);
                }
            }
            return letter;
        }

        char decodingReplacingLetter(char letter, int indexFoundLetter)
        {
            if (" "[0] == letter) return alphabet[34];
            indexFoundLetter = ((33 - indexFoundLetter));
            return alphabet[indexFoundLetter];
        }
    }
}
