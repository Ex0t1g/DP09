

namespace DP09;

public class PlainMapType : IMapType
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
                    map[i, j] = '.';
                }
            }
            return map;
        };
    }
}
