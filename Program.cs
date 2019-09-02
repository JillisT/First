using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //String name = "Jillis";
            //String variabele1 = "C ";
            //int nummer1 = 123;
            //Double nummer2 = 1.5;
            //Boolean status = false;
            //var rest = nummer1 % nummer2;
            //Console.WriteLine("Hello " + name);
            //Console.WriteLine(variabele1 + nummer1);
            //Console.WriteLine(nummer2.ToString() + (" ") + status.ToString());
            //Console.WriteLine(rest);
            //Console.WriteLine("Druk op een knop om door te gaan");
            //Console.ReadKey();
            //Console.Clear();
            //String bericht = "Geef een temperatuur in Celsius:";
            //Console.WriteLine(bericht);
            //int Celsius;
            //Celsius = Convert.ToInt32(Console.ReadLine());
            //Double fahrenheid = Celsius * 1.8 + 32;
            //Console.WriteLine("De temperatuur in Fahrenheid is: " + fahrenheid + "F");
            //Console.WriteLine("Druk op een knop om door te gaan");
            //Console.ReadKey();
            //Console.Clear();
            //Console.WriteLine("Bedrag in euro's");
            //int Euros;
            //Euros = Convert.ToInt32(Console.ReadLine());
            //Double Dollars = Euros * 1.16;
            //Console.WriteLine(Euros + " EUR is " + Dollars + " USD");
            //Console.WriteLine("Druk op een knop om door te gaan");
            //Console.ReadKey();
            //Console.Clear();

            Console.WriteLine("Please choose a language");
            Console.WriteLine("1. Nederlands");
            Console.WriteLine("2. English");
            int taal;
            taal = Convert.ToInt32(Console.ReadLine());

            String NL1 = "Bent u een man of een vrouw?";
            String EN1 = "Are you a man or a woman";
            String NL2 = "Wat is uw lengte in cm?";
            String EN2 = "What is your lenght in cm?";
            String NL3 = "Uw ideale gewicht is: ";
            String EN3 = "Your ideal weight is: ";
            String NL4 = "Wat is uw polsomtrek in cm?";
            String EN4 = "What is the length of your wrist in cm?";
            String NL5 = "Fout, typ man of vrouw";
            String EN5 = "Eror,type man or woman";
            String NL6 = "Fout, lengte moet tenminste 130cm zijn.";
            String EN6 = "Error, length has to be at least 130cm. ";
            String NL7 = "Fout, lengte mag niet meer dan 230cm zijn.";
            String EN7 = "Error, lenght cannot be more than 230cmn";
            String NL8 = "Fout, de polsomtrek mag niet minder dan 5cm zijn.";
            String EN8 = "Error, the wrist lenght cannot be less than 5cm";
            String NL9 = "Fout de polssomtrek mag niet meer dan 25cm zijn.";
            String EN9 = "Error, the wrist length cannot be more than 25cm";
            String NL10 = "Tot ziens";
            String EN10 = "Goodbye";

            if (taal == 1)
            {

                Double lengte;
                Double lengtev;
                Double polsomtrek;
                Console.WriteLine(NL1);
                String MV;
                MV = Console.ReadLine();
                Boolean conmv;
                if (MV == "Man" || MV == "man" || MV == "Vrouw" || MV == "vrouw")
                {
                    conmv = true;
                }
                else
                {
                    conmv = false;
                }
                while (conmv == false)
                {
                    Console.WriteLine(NL1);
                    MV = Console.ReadLine();
                    if (MV == "Man" || MV == "man" || MV == "Vrouw" || MV == "vrouw")
                    {
                        conmv = true;
                    }
                }
                if (MV == "Man" || MV == "man")
                {
                    Console.WriteLine(NL2);
                    lengte = Convert.ToDouble(Console.ReadLine());
                    while (lengte < 130 || lengte > 230)
                    {

                        if (lengte < 130)
                        {
                            Console.WriteLine(NL6);
                        }
                        if (lengte > 230)
                        {
                            Console.WriteLine(NL7);
                        }
                        Console.WriteLine(NL2);
                        lengte = Convert.ToDouble(Console.ReadLine());
                    }
                    Double gewicht = (lengte - 100) * 0.9;
                    Console.WriteLine(NL3 + gewicht);
                }
                else if (MV == "Vrouw" || MV == "vrouw")
                {
                    Console.WriteLine(NL2);
                    lengtev = Convert.ToDouble(Console.ReadLine());
                    while (lengtev < 130 || lengtev > 230)
                    {

                        if (lengtev < 130)
                        {
                            Console.WriteLine(NL6);
                        }
                        if (lengtev > 230)
                        {
                            Console.WriteLine(NL7);
                        }
                        Console.WriteLine(NL2);
                        lengtev = Convert.ToDouble(Console.ReadLine());
                    }
                    Console.WriteLine(NL4);
                    polsomtrek = Convert.ToDouble(Console.ReadLine());
                    while (polsomtrek < 5 || polsomtrek > 25)
                    {
                        if (polsomtrek < 5)
                        {
                            Console.WriteLine(NL8);
                        }
                        if (polsomtrek > 25)
                        {
                            Console.WriteLine(NL9);
                        }
                        Console.WriteLine(NL4);
                        polsomtrek = Convert.ToDouble(Console.ReadLine());
                    }
                    Double gewichtV = (lengtev + 4 * polsomtrek - 100) / 2;
                    Console.WriteLine(NL3 + gewichtV);
                }
                else
                {
                    Console.WriteLine(NL5);
                }

                Console.WriteLine(NL10);
                Console.ReadKey();
            }

            if (taal == 2)
            {

                Double lengte;
                Double lengtev;
                Double polsomtrek;
                Console.WriteLine(EN1);
                String MV;
                MV = Console.ReadLine();
                Boolean conmv;
                if (MV == "Man" || MV == "man" || MV == "Woman" || MV == "woman")
                {
                    conmv = true;
                }
                else
                {
                    conmv = false;
                }
                while (conmv == false)
                {
                    Console.WriteLine(EN1);
                    MV = Console.ReadLine();
                    if (MV == "Man" || MV == "man" || MV == "Woman" || MV == "woman")
                    {
                        conmv = true;
                    }
                }
                if (MV == "Man" || MV == "man")
                {
                    Console.WriteLine(EN2);
                    lengte = Convert.ToDouble(Console.ReadLine());
                    while (lengte < 130 || lengte > 230)
                    {

                        if (lengte < 130)
                        {
                            Console.WriteLine(EN6);
                        }
                        if (lengte > 230)
                        {
                            Console.WriteLine(EN7);
                        }
                        Console.WriteLine(EN2);
                        lengte = Convert.ToDouble(Console.ReadLine());
                    }
                    Double gewicht = (lengte - 100) * 0.9;
                    Console.WriteLine(EN3 + gewicht);
                }
                else if (MV == "Woman" || MV == "woman")
                {
                    Console.WriteLine(EN2);
                    lengtev = Convert.ToDouble(Console.ReadLine());
                    while (lengtev < 130 || lengtev > 230)
                    {

                        if (lengtev < 130)
                        {
                            Console.WriteLine(EN6);
                        }
                        if (lengtev > 230)
                        {
                            Console.WriteLine(EN7);
                        }
                        Console.WriteLine(EN2);
                        lengtev = Convert.ToDouble(Console.ReadLine());
                    }
                    Console.WriteLine(EN4);
                    polsomtrek = Convert.ToDouble(Console.ReadLine());
                    while (polsomtrek < 5 || polsomtrek > 25)
                    {
                        if (polsomtrek < 5)
                        {
                            Console.WriteLine(EN8);
                        }
                        if (polsomtrek > 25)
                        {
                            Console.WriteLine(EN9);
                        }
                        Console.WriteLine(EN4);
                        polsomtrek = Convert.ToDouble(Console.ReadLine());
                    }
                    Double gewichtV = (lengtev + 4 * polsomtrek - 100) / 2;
                    Console.WriteLine(EN3 + gewichtV);
                }
                else
                {
                    Console.WriteLine(EN5);
                }

                Console.WriteLine(EN10);
                Console.ReadKey();
            }


        }
    }
}






