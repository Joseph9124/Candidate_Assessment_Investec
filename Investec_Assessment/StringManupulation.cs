using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Investec_Assessment
{
    public class StringManupulation
    {
        private String str;
        private String option;

        int cntVowels = 0, contNonVowels = 0, totalNumVowels = 0;
        HashSet<char> uniqueChar = new HashSet<char>();
        char[] options;
        Boolean checkDuplicates = false;

        public StringManupulation(String str, String option)
        {
            this.str = str;
            this.option = option;
        }
        public String gettextString()
        {
            return str;
        }

        public String getOption()
        {
            return option;
        }
        static void Main(string[] args)
        {
            String textStringTest;
            String optionTest;

            Console.WriteLine("Enter text to be analysed");
            Console.Write("Type Text: ");
            textStringTest = Console.ReadLine();

            Console.WriteLine(" ");
            Console.WriteLine("Enter which operations to do on the supplied text," + "\n" + " ‘1’ for a duplicate character check," + "\n" + " ‘2’ to count the number of vowels," + "\n" + " ‘3’ to check if there are more vowels or non vowels, or any combination of ‘1’, ‘2’ and ‘3’ to perform multiple checks.");
            Console.Write("Type Option: ");
            optionTest = Console.ReadLine();
            Console.WriteLine("");

            StringManupulation sm = new StringManupulation(textStringTest, optionTest);
            sm.performOperations();

        }

        public void performOperations()
        {
            str = str.Replace(" ", "");
            String str1 = str.ToLower();
            char[] inp = str1.ToCharArray();
            options = option.ToCharArray();

            for (var i = 0; i < str.Length; i++)
            {
                for (var j = i + 1; j < str.Length; j++)
                {
                    if (inp[i] == inp[j])
                    {
                        uniqueChar.Add(inp[j]);
                        if (checkDuplicates == false)
                        {
                            checkDuplicates = true;
                        }
                        break;
                    }
                }
            }
            checkVowels(str1);
        }

        public void checkVowels(String str1)
        {
            var vowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u' };
            Boolean aVowel = false, eVowel = false, iVowel = false, oVowel = false, uVowel = false;

            for (int i = 0; i < str1.Length; i++)
            {

                if (vowels.Contains(str1[i]))
                {
                    totalNumVowels++;
                    if (str1[i] == 'a')
                    {
                        if (aVowel == false)
                        {
                            cntVowels++;
                            aVowel = true;
                        }
                    }
                    else if (str1[i] == 'a')
                    {
                        if (aVowel == false)
                        {
                            cntVowels++;
                            aVowel = true;
                        }
                    }
                    else if (str1[i] == 'e')
                    {
                        if (eVowel == false)
                        {
                            cntVowels++;
                            eVowel = true;
                        }
                    }
                    else if (str1[i] == 'i')
                    {
                        if (iVowel == false)
                        {
                            cntVowels++;
                            iVowel = true;
                        }
                    }
                    else if (str1[i] == 'o')
                    {
                        if (oVowel == false)
                        {
                            cntVowels++;
                            oVowel = true;
                        }
                    }
                    else if (str1[i] == 'u')
                    {
                        if (uVowel == false)
                        {
                            cntVowels++;
                            uVowel = true;
                        }
                    }
                }
                else
                {
                    contNonVowels++;
                }
            }
            var result = String.Join("", uniqueChar);
            List<char> list = uniqueChar.ToList();
            for (int i = 0; i < options.Length; i++)
            {
                if (options[i].Equals('1'))
                {
                    if (checkDuplicates)
                    {
                        Console.WriteLine("Found the following duplicates: " + result);
                    }
                    else
                    {
                        Console.WriteLine("No duplicate values were found");
                    }

                }
                else if (options[i].Equals('2'))
                {
                    if (cntVowels > 0)
                    {
                        Console.WriteLine("The number of vowels is " + cntVowels);
                    }
                    else
                    {
                        Console.WriteLine("No vowels were found.");
                    }

                }
                else if (options[i].Equals('3'))
                {
                    if (totalNumVowels > contNonVowels)
                    {
                        Console.WriteLine("The text has more vowels than non vowels");
                    }
                    else if (contNonVowels > totalNumVowels)
                    {
                        Console.WriteLine("The text has more non vowels than vowels");
                    }
                    else
                    {
                        Console.WriteLine("The text has an equal amount of vowels and non vowels");
                    }
                }
            }
        }
    }
}
