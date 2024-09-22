
namespace DP09;

public class ArchipelagoMapType : IMapType
{
    public MapGeneratorDelegate GenerateMap()
    {
        return () =>
        {
            char[,] map = new char[6, 6];
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    map[i, j] = '~';
                }
            }

            Random rand = new Random();
            int numIslands = rand.Next(4, 11);
            for (int i = 0; i < numIslands; i++)
            {
                int x = rand.Next(6);
                int y = rand.Next(6);
                map[x, y] = '.';
            }

            return map;
        };
    }
}
