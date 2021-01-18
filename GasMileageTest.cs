using System;

class GasMileageTest
{

    
    static void Main()
    {
        // define a new calculation
        GasMileage gasMileage = new GasMileage();

        // integer created possibility of repetition of the calculation
        int counter = 0;
        
        // prompt used to enter the amount of calculation wanted to be performed
        Console.Write("\nPlease enter the amount of calculations you like to perform: ");
        // input amount
        int limit = int.Parse(Console.ReadLine());

        // sentinel-controlled loop for the possibility of repetition
        while (counter < limit)
        {
            // prompt user to enter the amount of miles driven
            Console.Write("\nPlease enter the amount of miles driven: ");
            // input miles driven
            int gasMileagetheMilesDriven = int.Parse(Console.ReadLine());
            gasMileage.SetMilesDriven(gasMileagetheMilesDriven);

            // prompt user to enter gallons used
            Console.Write("Please enter the amount of gallons your vehicle used: ");
            // input gallons used
            int gasMileagetheGallons = int.Parse(Console.ReadLine());
            gasMileage.SetGallons(gasMileagetheGallons);

            // display fuel consumption with the required 2 decimal places
            Console.WriteLine($"The average fuel consuption is: {Math.Round(((double)gasMileage.GetMilesDriven() / (double)gasMileage.GetGallons()), 2)} ");

            // increase counter with 1
            ++counter;

        }
       

    }
}

