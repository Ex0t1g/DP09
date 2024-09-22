
namespace DP09;

public class PlainWithRiverMapType : IMapType
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
                    map[i, j] = '.';
                }
            }
            int riverStartX = 0;
            int riverStartY = rand.Next(6);
            int riverEndX = 5;
            int riverEndY = rand.Next(6);
            int currentX = riverStartX;
            int currentY = riverStartY;

            while (currentX < riverEndX)
            {
                map[currentX, currentY] = '~';
                currentX++;
                currentY += rand.Next(-1, 2);
                currentY = Math.Max(0, Math.Min(5, currentY));
            }
            map[riverEndX, riverEndY] = '~';
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (map[i, j] == '.' && rand.NextDouble() < 0.1)
                    {
                        map[i, j] = '&';
                    }
                }
            }

            return map;
        };
    }
}
