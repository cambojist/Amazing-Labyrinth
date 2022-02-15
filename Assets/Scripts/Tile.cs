using System.Collections.Generic;

namespace DefaultNamespace
{
    public class Tile
    {
        public TileType Type { get; set; }
        public int Angle { get; set; }
        public List<int> Paths { get; set; }

        public Tile(TileType type, int angle)
        {
            Type = type;
            Angle = angle;
        }
    }
}