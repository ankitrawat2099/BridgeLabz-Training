using System;

class VolumeCalculator
{
    static void Main(String[] args)
    {
        double earthRadiusKm = 6378;
		//pie value
        double pieValue = Math.PI;
		// convert radius from km to miles
        double earthRadiusMiles = earthRadiusKm*1.6;;
//finding the volume 
        double volumeInCubicKm = (4.0 / 3.0) * pieValue * Math.Pow(earthRadiusKm, 3);
        double volumeInCubicMiles =(4.0 / 3.0) * pieValue * Math.Pow(earthRadiusMiles, 3);

        Console.WriteLine("The volume of earth in cubic kilometers is " + volumeInCubicKm +" and cubic miles is " + volumeInCubicMiles
        );
    }
}
