using OOPWeek8_Chybuk;

        Letter letter1 = new Letter("Letter228", 0.67);
        Letter letter2 = new Letter("Letter67", 0.52);
        Parcel parcel1 = new Parcel("ParcelAli", 2.4, "30x20x15");
        Parcel parcel2 = new Parcel("ParcelTemu", 10.5, "70x50x32");

        Console.WriteLine("letter inf:");
        letter1.PrintInfo();
        Console.WriteLine($"cost: {letter1.CalculateCost()} uah");
        Console.WriteLine();

        Console.WriteLine("parcel inf");
        parcel1.PrintInfo(); 
        Console.WriteLine($"cost: {parcel1.CalculateCost()} uah"); 
        Console.WriteLine();