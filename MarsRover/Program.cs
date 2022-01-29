using MarsRover.Model;
using System;

namespace MarsRover
{
    public static class Program
    {
        public static DirectionEnum direction = DirectionEnum.N;        
        public static void Process(this Rover rover, string command)
        {
            for (int i = 0; i < command.Length; i++)
            {
                if ('L' == command[i])
                    direction = ((int)direction - 1) < (int)DirectionEnum.N ? DirectionEnum.W : (DirectionEnum)((int)direction - 1);
                else if ('R' == command[i])
                    direction = ((int)direction + 1) > (int)DirectionEnum.W ? DirectionEnum.N : (DirectionEnum)((int)direction + 1);
                else if ('M' == command[i])
                {
                    rover.Move();
                }
            }
        }
        public static bool Move(this Rover rover)
        {
            switch (direction)
            {
                case DirectionEnum.N:
                    rover.position.y += 1;
                    break;
                case DirectionEnum.E:
                    rover.position.x += 1;
                    break;
                case DirectionEnum.S:
                    rover.position.y -= 1;
                    break;
                case DirectionEnum.W:
                    rover.position.x -= 1;
                    break;
            }

            return true;
        }
        static void Main(string[] args)
        {
            Plateau plateau = new Plateau();
            plateau.height = 5;
            plateau.width = 5;
            Position position = new Position();
            position.x = 1;
            position.y = 2;

            Rover rover = new Rover();
            rover.plateau = plateau;
            rover.position = position;
            rover.direction = DirectionEnum.N;
            rover.Process("LMLMLMLMM");
            Console.WriteLine(rover.position.x + " " + rover.position.y + " " + rover.direction); // 1 3 N

            rover.position.x = 3;
            rover.position.y = 3;
            rover.direction = DirectionEnum.E;       
            rover.Process("MMRMMRMRRM");
            Console.WriteLine(rover.position.x + " " + rover.position.y + " " + rover.direction); //5 1 E
        }
    }
}
