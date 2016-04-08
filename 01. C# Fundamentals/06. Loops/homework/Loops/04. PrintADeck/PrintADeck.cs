namespace _04.PrintADeck
{
    using System;
    using System.Text;

    public class PrintADeck
    {
        public static void Main()
        {
            string inputCard = Console.ReadLine();
            int someValue = 0;
            int count = 0;
            StringBuilder result = new StringBuilder();
            if (!int.TryParse(inputCard, out someValue))
            {
                string symbolToUpper = inputCard.ToString().ToUpper();
                count = symbolToUpper == "J" ? 11 : count;
                count = symbolToUpper == "Q" ? 12 : count;
                count = symbolToUpper == "K" ? 13 : count;
                count = symbolToUpper == "A" ? 14 : count;

                inputCard = symbolToUpper;
            }
            else
            {
                count = int.Parse(inputCard);
            }

            for (int i = 2; i <= count; i++)
            {
                string currentSymbol = i.ToString();
                if (i > 10)
                {
                    currentSymbol = i == 11 ? "J" : currentSymbol;
                    currentSymbol = i == 12 ? "Q" : currentSymbol;
                    currentSymbol = i == 13 ? "K" : currentSymbol;
                    currentSymbol = i == 14 ? "A" : currentSymbol;
                }

                result.AppendLine(string.Format("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", currentSymbol.ToString()));
            }

            result.Length = result.Length - 1;
            Console.WriteLine(result.ToString());
        }
    }
}

// Write a program that reads a card sign(as a char) from the console and generates and prints all possible cards from a standard deck of 52 cards up 
// to the card with the given sign(without the jokers). The cards should be printed using the classical notation(like 5 of spades, A of hearts, 9 of clubs;
// and K of diamonds).
// 
// The card faces should start from 2 to A.
// Print each card face in its four possible suits: clubs, diamonds, hearts and spades.