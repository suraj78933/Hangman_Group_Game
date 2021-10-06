using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Hangman_Group_Game.Bussiness
{
    class GamePlayOperations
    {
        private static string[] FruitData()
        {
            string[] fruits = new string[] {
                "Apple",
                "Avocado",
                "Banana",
                "Blackberries",
                "Blackcurrant",
                "Cherries",
                "Coconut",
                "Date",
                "Dragonfruit",
                "Figs",
                "Grapes",
                "Guava",
                "Jackfruit",
                "Kiwifruit",
                "Lychee",
                "Mango",
                "Orange",
                "Papaya",
                "Peaches",
                "Pear",
                "Pomegranate",
                "Strawberries",
                "Watermelon",
            };
            return fruits;
        }

        private static IEnumerable<string> GetFruits(string[] fruits)
        {
            List<string> listNames = new List<string>();

            foreach (string fruit in fruits)
            {
                listNames.Add(fruit.ToLower());
            }
            return listNames;
        }

        private static int RandomNumber(int maximumLength)
        {
            Random myRandom = new Random();
            int randNum = myRandom.Next(0, maximumLength);
            return randNum;
        }

        public static string GetRandomWord()
        {
            List<string> Words = new List<string>();
            Words.AddRange(GetFruits(FruitData()));
            return Words[RandomNumber(Words.Count)];
        }
    }
}