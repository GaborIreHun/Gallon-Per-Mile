using System;

class GasMilageTest
{

    
    static void Main()
    {
        
        GasMilage gasMilage = new GasMilage();

        int counter = 0;
        

        Console.Write("\nPlease enter the amount of calculations you like to perform: ");
        int limit = int.Parse(Console.ReadLine());

        while (counter < limit)
        {
            Console.Write("\nPlease enter the amount of miles driven: ");
            int gasMilagetheMilesDriven = int.Parse(Console.ReadLine());
            gasMilage.SetMilesDriven(gasMilagetheMilesDriven);

            Console.Write("Please enter the amount of gallons your vehicle used: ");
            int gasMilagetheGallons = int.Parse(Console.ReadLine());
            gasMilage.SetGallons(gasMilagetheGallons);

            Console.WriteLine($"The average fuel consuption is: {Math.Round(((double)gasMilage.GetMilesDriven() / (double)gasMilage.GetGallons()), 2)} ");

            ++counter;

        }
       

    }
}

