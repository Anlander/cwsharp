namespace hemuppgift
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //uppgift1();
            //uppgift2();
            //uppgift3();
            //uppgift4();
            //Console.ReadLine();


            /* 1 */
            double val = Converter(4.22);
            Console.WriteLine(val);

            /* 2 */
            Console.Write("Skriv ett tal: ");
            int val2 = Convert.ToInt32(Console.ReadLine());
            CheckEven(val2);

            /* 3 */
            Console.Write("Skriv studentens poäng: ");
            int val3 = Convert.ToInt32(Console.ReadLine());
            CheckStudentScore(val3);

            /* 4 */
            Console.Write("Write a value: ");
            char val4 = Console.ReadKey().KeyChar;
            Console.WriteLine(" ");
            CheckOperator(val4);

            /* 5 */
            string iLike = "I like";
            string youLike = "You like";
            string EveryOneLike = "Everyone likes";
            Console.Write(iLike + " ");
            Display();
            Console.Write(youLike + " ");
            Display();
            Console.Write(EveryOneLike + " ");
            Display();
            Console.WriteLine(" ");

            /* 6 */
            Console.WriteLine(ReturnDisplay(iLike));
            Console.WriteLine(ReturnDisplay(youLike));
            Console.WriteLine(ReturnDisplay(EveryOneLike));






        }
        /* Hemuppgift 1 */
        static void uppgift1()
        {
            int a = 5;
            int b = 10;

            Console.WriteLine($"Förebyte: a = {a} b = {b}");


            int temp = a;
            a = b;
            b = temp;

            Console.WriteLine($"Efterbyte: a = {a} b = {b}");

        }
        static void uppgift2()
        {
            Console.Write("Ange rektanglens längd: ");
            double length = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ange rektanglns bredd: ");
            double height = Convert.ToDouble(Console.ReadLine());

            double omkrets = length * 2 + height * 2;
            double area = length * height;

            Console.WriteLine($"Omkretsen: {omkrets}");
            Console.WriteLine($"Area: {area}");

        }
        static void uppgift3()
        {
            Console.Write("Vilket tal vill du kontrollera om det är udda / jämt?: ");
            int number = Convert.ToInt32(Console.ReadLine());


            if (number % 2 == 0)
            {
                Console.WriteLine($"{number} är jämt!");
            }
            else
            {
                Console.WriteLine($"{number} är ojämt!");
            }
        }
        static void uppgift4()
        {
            Console.Write("Ange din e-postadress: ");
            string email = Console.ReadLine();
            char at = '@';

            int position = email.IndexOf(at);


            if (email.Contains(at))
            {

                if (position != -1)
                {
                    string beforeAt = email.Substring(0, position);
                    Console.WriteLine(" ");
                    Console.WriteLine("Användarnamn från e-post: " + beforeAt);
                    Console.WriteLine($"E-postadressen: {email} är giltig");

                }
            }
            else
            {
                Console.WriteLine("E-postadressen är inte giltig");
                uppgift4();
            }

        }

        /* Hemuppgift 2 */
        static int Converter(double a)
        {

            return Convert.ToInt32(a);
        }
        static void CheckEven(int a)
        {
            bool value = a % 2 == 0;
            if (value)
            {
                Console.WriteLine($"{a} är ett jämnt tal");
            }
            else
            {
                Console.WriteLine($"{a} är ett ojämt tal");

            }
        }
        static void CheckStudentScore(int a)

        {
            //if (a >= 0 && a <= 20)
            //{
            //    Console.WriteLine("F");
            //}
            //else if (a >= 21 && a <= 40)
            //{
            //    Console.WriteLine("C");
            //}
            //else if (a >= 41 && a <= 80)
            //{
            //    Console.WriteLine("B");
            //}
            //else if (a >= 81 && a <= 100)
            //{
            //    Console.WriteLine("A");
            //}
            //else
            //{
            //    Console.WriteLine("Range between 0-100");
            //}

            switch (a)
            {
                case int n when (n >= 0 && n <= 20):
                    Console.WriteLine("F");
                    break;
                case int n when (n >= 21 && n <= 40):
                    Console.WriteLine("C");
                    break;
                case int n when (n >= 41 && n <= 80):
                    Console.WriteLine("D");
                    break;
                case int n when (n >= 81 && n <= 90):
                    Console.WriteLine("B");
                    break;
                case int n when (n >= 91 && n <= 100):
                    Console.WriteLine("A");
                    break;
                default:
                    Console.WriteLine("Range between 0-100");
                    break;
            }
        }
        static void CheckOperator(char val)
        {
            if (char.IsUpper(val))
            {
                Console.WriteLine("Value is capitilized");
            }
            else if (char.IsLower(val))
            {
                Console.WriteLine("Value is lowercase");
            }
            else if (char.IsDigit(val))
            {
                Console.WriteLine("Value is a number");
            }
            else
            {
                Console.WriteLine("Value is special letter");
            }
        }


        static void Display()
        {
            Console.WriteLine("C# programming language");
        }

        static string ReturnDisplay(string str)
        {
            string value = $"{str} C# programming language";
            return value;
        }
    }
}

