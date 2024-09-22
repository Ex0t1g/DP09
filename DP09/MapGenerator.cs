namespace DP09;

public class MapGenerator
{
    private MapGeneratorDelegate _mapGenerator;

    protected internal void SetStrategy(MapGeneratorDelegate mapGenerator)
    {
        _mapGenerator = mapGenerator;
    }

    public void GenerateAndPrintMap()
    {
        char[,] map = _mapGenerator();
        PrintMap(map);
    }

    private void PrintMap(char[,] map)
    {
        for (int i = 0; i < 6; i++)
        {
            for (int j = 0; j < 6; j++)
            {
                Console.Write(map[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
