using System;

namespace tekrar_methodlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numArr = { 127, 3, 34, 52};
            int[] newNumArr = new int[11];

            ////numArr.CopyTo(newNumArr, );
            //Array.Copy(numArr, 0, newNumArr, 5, 4);
            ////Array.Clear(newNumArr, 0, 10);


            Array.Sort(numArr);
            Array.Reverse(numArr);
            Array.Resize(ref numArr, 2);


            for (int i = 0; i < numArr.Length; i++)
            {
                Console.WriteLine(numArr[i]);
            }
            int[] numArr2 = { 127, 3, 34, 52,119 };

            Console.WriteLine(Array.IndexOf(numArr2, 3));
            Console.WriteLine(Array.LastIndexOf(numArr2, 3));

            string text = " Salam doslar !   ";

            Console.WriteLine(text.ToLower());
            Console.WriteLine(text.ToUpper());
            Console.WriteLine(text.Trim());
            Console.WriteLine(text.Replace(' ', '-'));
            Console.WriteLine(text.Replace('H', 'A'));
            Console.WriteLine(text.Replace("doslar", "PB302"));
            Console.WriteLine(text);
            Console.WriteLine(text.Contains("lar "));
            Console.WriteLine(text.Trim().ToUpper().StartsWith("SA"));
            Console.WriteLine(text.EndsWith("r !   "));

            string str = "Bugun  ucun derslerini  oxumusan  ?";

            Console.WriteLine(str.IndexOf("ucun"));
            Console.WriteLine(str.IndexOf('u'));
            Console.WriteLine(str.LastIndexOf('u'));

            var newStr = str.Substring(0, 4);
            Console.WriteLine(newStr);

            var arr = str.Split(' ');

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

            var newStr2 = String.Join('-', arr);
            Console.WriteLine(newStr2);

            char letter = 'a';

            Console.WriteLine(char.ToUpper('d'));
            Console.WriteLine(char.IsDigit('d'));
            Console.WriteLine(char.IsUpper('o'));
            Console.WriteLine(char.IsLetter('B'));
            Console.WriteLine(char.IsLetterOrDigit('a'));
        }
    }
}
