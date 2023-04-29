
// Zmienne tekstowe
using System.ComponentModel.Design;
using System.Globalization;
using System.Linq.Expressions;

internal class Program
{
    public static bool Mężczyzna { get; private set; }

    private static void Main(string[] args)
    {
        string name = "Adam";
        string surname = "Kamizelich";
        string result = name + surname;
        var ageAdam = "33";

        Console.WriteLine(result);
        string result1 = name + surname + ageAdam;
        Console.WriteLine("Adam Kamizelich 56");
        Console.WriteLine(result1);

        //Zamiast nazwiska wstawiamy 1
        string nameA = "Adam";
        string surname1 = "1";
        string result2 = nameA + surname1 + ageAdam;
        Console.WriteLine(result2);

        //Zmienna char

        char myVar = 'c';

        //można podzielić( Split) zmienną string np.( name) na char czyli 

        // var result3 = name3.Split;
        // var result4 = name4.ToArray();
        //Console.WriteLine(result3); 


        //Do podziału służą Split lub ToArray

        //ZmiennaLogiczna 
        //bool isActive = false;
        //bool isActive = true;

        bool isActive = true;
        isActive = false;
        var isValid = 5 > 6;
        Console.WriteLine(isValid);

        //Zadanie dzień 4
        var ageKobieta = 29;
        string nameEwa = "Ewa";
        string Gender = "Kobieta, lat";
        var ageEwa = 33;
        string result5 = nameEwa + Gender + ageEwa;
        Console.WriteLine(result5);
        if (Gender == "Kobieta, lat")
        {
            if (ageKobieta == 29 && ageKobieta <= 30)
            {
                Console.WriteLine("Kobieta, mniej niż 30lat ");
            }

            {
                var nameAdult = "Pełnoletni";
                var nameMinor = "Niepełnoletni";
                var gender = "Mężczyzna";
                var ageAdult = 18;
                var ageMinor = "<18";
                isActive = true;

                if (Gender == "Mężczyzna" & ageAdult == 18)
                    if (gender == "Mężczyzna" && nameAdult == "Pełnoletni")
                    {

                    }
                {
                    Console.WriteLine("Mężczyzna Pełnoletni");
                }

                if (ageMinor == "<18" && gender ==  "Mężczyzna")
                {
                    Console.WriteLine("Mężczyzna Niepełnoletni");

                }
            }



            bool genderMarcin = Mężczyzna;
            isActive = true;

            if (genderMarcin == Mężczyzna)
            {
                Console.WriteLine("");
            }

            {
                Console.WriteLine("Marcin Mężczyzna");

            }
            {


                    {
                        Console.WriteLine("Marcin");
                    }

                    {
                        Console.WriteLine(value: "Marcin, nie jest Mężczyzna");
                        if (isActive = true)
                        {

                        }
                    }
                }
            }
        }
    }



        