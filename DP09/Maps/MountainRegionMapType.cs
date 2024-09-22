

namespace DP09;

public class MountainRegionMapType : IMapType
{
    public MapGeneratorDelegate GenerateMap()
    {
        return () =>
        {
            char[,] map = new char[6, 6];
            Random rand = new Random();
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    map[i, j] = rand.Next(2) == 0 ? '^' : '&';
                }
            }
            return map;
        };
    }
}
