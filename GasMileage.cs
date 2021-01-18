// This program calculates the fuel consumption of a vehicle.

class GasMileage
{
    // declaring properties 
    public int milesDriven;

    public int gallons;

    // property to set miles driven
    public void SetMilesDriven(int gasMileageMilesDriven)
    {
        milesDriven = gasMileageMilesDriven;
    }

    // property to return miles driven
    public int GetMilesDriven()
    {
        return milesDriven;
    }

    // property to set gallons used 
    public void SetGallons(int gasMileageGallons)
    {
        gallons = gasMileageGallons;
    }

    // property to return gallons used
    public int GetGallons()
    {
        return gallons;
    }
        
}
