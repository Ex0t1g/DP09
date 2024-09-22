namespace DP09;

internal class Program
{
    static void Main(string[] args)
    {
        MapGenerator mapGenerator = new MapGenerator();

        Console.WriteLine("Выберите тип карты:");
        Console.WriteLine("1. Равнина");
        Console.WriteLine("2. Горный регион");
        Console.WriteLine("3. Архипелаг");
        Console.WriteLine("4. Равнина с рекой");

        int choice = int.Parse(Console.ReadLine()!);

        IMapType mapType;
        switch (choice)
        {
            case 1:
                mapType = new PlainMapType();
                mapGenerator.SetStrategy(mapType.GenerateMap());
                break;
            case 2:
                mapType = new MountainRegionMapType();
                mapGenerator.SetStrategy(mapType.GenerateMap());
                break;
            case 3:
                mapType = new ArchipelagoMapType();
                mapGenerator.SetStrategy(mapType.GenerateMap());
                break;
            case 4:
                mapType = new PlainWithRiverMapType();
                mapGenerator.SetStrategy(mapType.GenerateMap());
                break;
            default:
                Console.WriteLine("Неверный выбор.");
                return;
        }

        mapGenerator.GenerateAndPrintMap();
    }
}
