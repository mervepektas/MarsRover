using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Model
{
    public class Plateau
    {
        public int min_Width { get; set; }

        public int min_Height { get; set; }

        public int width { get; set; }

        public int height { get; set; }
    }
    public class Position
    {
        public int x { get; set; }

        public int y { get; set; }
    }
    public enum DirectionEnum
    {
        N = 1,
        E = 2,
        S = 3,
        W = 4
    }
    public class Rover
    {
        public Plateau plateau { get; set; }

        public Position position { get; set; }

        public DirectionEnum direction { get; set; }
    }
}
