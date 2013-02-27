using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace CodeDojoTest
{
    [TestClass]
    public class LinqTestProblems
    {
        [TestMethod]
        public void ThisIsAnExample()
        {
            //Print the score higher than 80
            //Output: 85 90 88
            var scores = new[] { 70, 85, 90, 88 };

            var higherThan80 = scores.Where(score =>
                                                {
                                                    return score > 80;
                                                });
            higherThan80.ToList().ForEach(Console.WriteLine);
//            foreach (var i in higherThan80)
//            {
//                Console.WriteLine(i);
//            }
        }

        [TestMethod]
        public void T1_CalculatAverage()
        {
            //Get the average of  1^2 + 2^2 + ... + 10^2
        }

        [TestMethod]
        public void T2_FilterItemsContainedByOtherArrayAndKeepTheOriginalOrder()
        {
            //Output: david carry
            string[] names1 = { "nick", "david", "carry" };
            string[] names2 = { "carry", "david" };
        }

        [TestMethod]
        public void T3_SelectTheLeftOnes()
        {
            //Output: nick
            string[] names1 = { "nick", "david", "carry" };
            string[] names2 = { "carry", "david" };
        }

        [TestMethod]
        public void T4_GetAllUppercaseItems()
        {
            //Output:NICK DAVID CARRY
            string[] names = { "nick", "david", "carry" };
            names.Select(x => x.ToUpper()).ToList().ForEach(Console.Write);
        }

        [TestMethod]
        public void T5_ConcatAllTheItemsWithSpaceAsTheDelimiter()
        {
            //Output:"nick david carry"
            string[] names = { "nick", "david", "carry" };

            var aggregate = names.Aggregate((current, next) => current + " " + next);

        }

        [TestMethod]
        public void T6_SortArrayAscending()
        {
            //Output:carry david nick 
            string[] names = { "nick", "david", "carry" };
            names.OrderBy(x => x).ToList();
        }

        [TestMethod]
        public void T7_SortArrayDescending()
        {
            //Output: nick david carray
            string[] names1 = { "nick", "david", "carry" };
            names1.OrderByDescending(x => x);
        }

        [TestMethod]
        public void T8_PrintAllFlowerNamesIfAnyBouquetHasFlowerNameStartWithDByOnlyOneForeach()
        {
            /*Output: 
            sunflower
            daisy
            daffodil
            larkspur
             */
            var bouquets = new List<Bouquet>
                               {
                                   new Bouquet {Flowers = new List<string> {"sunflower", "daisy"}},
                                   new Bouquet {Flowers = new List<string> {"tulip", "rose", "orchid"}},
                                   new Bouquet {Flowers = new List<string> {"daffodil", "larkspur"}}
                               };
        }

        [TestMethod]
        public void T9_MakeWordWithRandomLetters()
        {
            //Possbile output: apphy
            const string word = "happy";
        }

        [TestMethod]
        public void T10_MakeWordStarAndEndLetterUnchangedButMiddleLettersInRamdonOrder()
        {
            //Possbile output: hppay
            const string word = "happy";
        }

        [TestMethod]
        public void T11_SortALongString()
        {
            //Output: does It matter not
            const string text = "It does not matter";
        }

        [TestMethod]
        public void T12_CountWordOccurence()
        {
            //Count the occurence of words and output them in descending, ignore case
            const string text = "Historically, the world of data and the world of objects" +
                                " have not been well integrated. Programmers work in C# or Visual Basic" +
                                " and also in SQL or XQuery. On the one side are concepts such as classes," +
                                " objects, fields, inheritance, and .NET Framework APIs. On the other side" +
                                " are tables, columns, rows, nodes, and separate languages for dealing with" +
                                " them. Data types often require translation between the two worlds; there are" +
                                " different standard functions. Because the object world has no notion of query, a" +
                                " query can only be represented as a string without compile-time type checking or" +
                                " IntelliSense support in the IDE. Transferring data from SQL tables or XML trees to" +
                                " objects in memory is often tedious and error-prone.";
        }

        [TestMethod]
        public void T13_ScrambleTextByWord()
        {
            //Possisble Output:            
            //const string text1 = "Adcorcing to a rrseaech at Cambgidre Univeristy it does not mttaer in waht oredr the letters in a wrod are";
            const string text =
                "According to a research at Cambridge University it does not matter in what order the letters in a word are";
        }


        [TestMethod]
        public void T14_SortByObjectProperty()
        {
            //Output: dog1 dog3 dog5 dogspecial dog2 dog4
            var dog1 = new Dog { IsMale = true, Name = "dog1" };
            var dog2 = new Dog { IsMale = false, Name = "dog2" };
            var dog3 = new Dog { IsMale = true, Name = "dog3" };
            var dogSpecial = new Dog { Name = "specialDog" };
            var dog4 = new Dog { IsMale = false, Name = "dog4" };
            var dog5 = new Dog { IsMale = true, Name = "dog5" };
            var dogs = new List<Dog> { dog1, dog2, dog3, dog4, dog5};
        }

        public class Dog
        {
            public bool IsMale;
            public string Name;
        }

        internal class Bouquet
        {
            public List<string> Flowers { get; set; }
        }
    }
}