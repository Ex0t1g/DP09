

namespace DP09;
public delegate char[,] MapGeneratorDelegate();

public interface IMapType
{
    MapGeneratorDelegate GenerateMap();
}
