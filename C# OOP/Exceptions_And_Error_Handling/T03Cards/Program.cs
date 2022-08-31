using System;
using System.Collections.Generic;
using System.Text;


namespace T03Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);

            List<Card> cards = new List<Card>();
            for (int i = 0; i < input.Length - 1; i += 2)
            {
                try
                {
                    string cardFace = input[i];
                    string cardSuit = input[i + 1];
                    cards.Add(CreateCard(cardFace, cardSuit));
                }
                catch (ArgumentException ae)
                {
                    Console.WriteLine(ae.Message);
                }

            }

            foreach (Card item in cards)
            {
                Console.Write(item + " ");
            }

        }
        public static Card CreateCard(string face, string suit)
        {
            List<string> cardFaces = new List<string>() { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
            Dictionary<string, string> cardSuits = new Dictionary<string, string>()
            {
                {"S", "\u2660"},
                {"H", "\u2665"},
                {"D", "\u2666"},
                {"C", "\u2663"}
            };

            if (!cardFaces.Contains(face) || !cardSuits.ContainsKey(suit))
            {
                throw new ArgumentException("Invalid card!");
            }

            Card card = new Card(face, cardSuits[suit]);
            return card;
        }
    }

    public class Card
    {
        public Card(string face, string suit)
        {
            Face = face;
            Suit = suit;
        }

        public string Face { get; set; }
        public string Suit { get; set; }

        public override string ToString()
        {
            return $"[{Face}{Suit}]";
        }
    }

}

