using Lab_5;

internal class Program
{
    private static void Main(string[] args)
    {
        WindInstrument Winstrument1 = new WindInstrument("Saxophone", "Yamaha", "Alto", 2020, "Gold", 1, 19, 1, 8);
        WindInstrument Winstrument2 = new WindInstrument("Trumpet", "Bach", "Stradivarius", 2018, "Silver", 1, 3, 3, 0);
        PercussionInstrument Pinstrument1 = new PercussionInstrument("Drum Set", "Pearl", "Masterworks", 2019, "Black", 1, 5, 3, 7);
        PercussionInstrument Pinstrument2 = new PercussionInstrument("Cajon", "Meinl", "Artisan", 2021, "Natural", 1, 1, 1, 2);
        StringedInstrument Sinstrument1 = new StringedInstrument("Electric Guitar", "Fender", "Stratocaster", 2022, "Sunburst", 1, 6, 22, 6);
        StringedInstrument Sinstrument2 = new StringedInstrument("Violin", "Stradivarius", "Concert", 2019, "Brown", 1, 4, 20, 4);
        MusicalInstrument Minstrument1 = new MusicalInstrument("Piano", "Steinway", "Grand", 2020, "Black", 1);
        MusicalInstrument Mstrument2 = new MusicalInstrument("Acoustic Guitar", "Taylor", "814ce", 2021, "Natural", 1);

        WindInstrument WinstrumentEdit = new WindInstrument("sfsfsdfsdfsd", "Yamaha", "Alto", 2020, "Gold", 1, 19, 1, 8);

        Music misuc = new Music(Winstrument1, Winstrument2, Pinstrument1, Pinstrument2, Sinstrument1, Sinstrument2, Minstrument1);

        Console.WriteLine("Початковий масив:");
        Console.WriteLine(misuc.ToString());

        misuc.AddInstrument(Mstrument2);
        Console.WriteLine("Додавання:");
        Console.WriteLine(misuc.ToString());

        Console.WriteLine("Редагування:");
        misuc.EditInstrument(0, WinstrumentEdit);
        Console.WriteLine(misuc.ToString());

        Console.WriteLine("Видалення:");
        misuc.RemoveInstrument(1);
        Console.WriteLine(misuc.ToString());
    }
}