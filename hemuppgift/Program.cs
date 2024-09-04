namespace hemuppgift
{
    public class Program
    {
        public static void Main(string[] args)
        {
            uppgift1();
            uppgift2();
            uppgift3();
            uppgift4();
            Console.ReadLine();
        }

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
    }
}
