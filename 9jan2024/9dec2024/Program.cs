using System;
using System.Globalization;
using System.Linq;

namespace _9dec2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Domain("mulayimen@code.edu.az"));

            Console.WriteLine(OnlyLetters("salam61"));

            Console.WriteLine(Capitalize("sAlaM nEcEsEn"));

            string[] fullnames = { "Jonas Bentley", "George Miller", "Lilith Appleton" };

            string[] firstNames = Names(fullnames);
            for (int i = 0; i < firstNames.Length; i++)
            {
                Console.WriteLine(firstNames[i]);
            }

            DateTime birthDate = new DateTime(2005, 5, 11); 
            int age = MyAge(birthDate);
            Console.WriteLine($"Yaşınız : {age}");

        }
        #region Verilmiş email dəyərinin domain hissəni qaytaran metod
        static string Domain(string email)
        {
            return email.Substring(email.IndexOf('@') + 1);
        }

        #endregion

        #region Verilmiş yazının yalnız hərflərdən ibarət olub olmadığını tapan metod
        static bool OnlyLetters(string str)
        {
            return str.All(char.IsLetter);  
        }

        #endregion

        #region Verilmiş yazının ilk hərfini böyük qalanlarını kiçik edib qaytaran metod
        static string Capitalize(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return str;
            }
            char firstChar = char.ToUpper(str[0]);
            string restOfTheString = str.Substring(1).ToLower();

            return firstChar + restOfTheString;

        }

        #endregion

        #region Verilmiş fullnamelər siyahısından name-lər siyahısı düzəldən metod(ad soyadlar siyahısındaki adları kəsib yeni bir arraye doldurub qaytarmalıdır)
        static string[] Names(string[] arr)
        {
            string[] names = new string[arr.Length]; 

            for (int i = 0; i < arr.Length; i++)
            {
                int spaceIndex = arr[i].IndexOf(' '); 
                if (spaceIndex != -1) 
                {
                    names[i] = arr[i].Substring(0, spaceIndex); 
                }
                else
                {
                    names[i] = arr[i]; 
                }
            }
            return names; 
        }

        #endregion

        #region Doğum tarixinizi daxil etdiyinizdə sizə yaşınızı qaytaran metod
        static int MyAge(DateTime birthdate)
        {
            DateTime currentDate = DateTime.Now; 

            int age = currentDate.Year - birthdate.Year; 

            if (birthdate.Date > currentDate.AddYears(-age))
            {
                age--; 
            }

            return age; 
        }
        #endregion

    }

}