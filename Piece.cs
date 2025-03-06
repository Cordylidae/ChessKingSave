using System;
using System.Collections.Generic;

namespace MagicChessBoard
{
    public struct Point
    {
        public int x;
        public int y;
        public Point(int _x, int _y)
        {
            x = _x;
            y = _y;
        }
    }

    static public class AllDir
    {
        static public Point Up = new Point(0, 1);
        static public Point UpRight = new Point(1, 1);
        static public Point Right = new Point(1, 0);
        static public Point RightDown = new Point(1, -1);

        static public Point Down = new Point(0, -1);
        static public Point DownLeft = new Point(-1, -1);
        static public Point Left = new Point(-1, 0);
        static public Point LeftUp = new Point(-1, 1);
    }

    class Piece
    {
        public enum Type { Pawn, Knight, Rook, Bishop, Queen, King }
        public enum Color { Black, White}
        

        public Type type;
        public Color color;
        public Point point;
        public int length;

        public List<Point> dirs;
                
        public Piece(Type _type, Color _color, Point _point, int _length)
        {
            type = _type;
            color = _color;
            point = _point;
            length = _length;

            SetUpDirs(type);
        }

        public Piece(Piece other)
        {
            type = other.type;
            color = other.color;
            point = new Point(other.point.x, other.point.y); // Deep copy
            length = other.length;
            dirs = new List<Point>(other.dirs); // Copy list
        }

        private void SetUpDirs(Type type)
        {
            dirs = new List<Point>();

            switch (type)
            {
                case Type.Pawn:
                    {
                        dirs.Add(AllDir.Up);
                        dirs.Add(AllDir.Right);
                        dirs.Add(AllDir.Down);
                        dirs.Add(AllDir.Left);

                        length = 1;
                    }
                    break;
                case Type.Rook:
                    {
                        dirs.Add(AllDir.Up);
                        dirs.Add(AllDir.Right);
                        dirs.Add(AllDir.Down);
                        dirs.Add(AllDir.Left);
                    }
                    break;
                case Type.Bishop:
                    {
                        dirs.Add(AllDir.UpRight);
                        dirs.Add(AllDir.LeftUp);
                        dirs.Add(AllDir.DownLeft);
                        dirs.Add(AllDir.RightDown);
                    }
                    break;
                case Type.Queen:
                    {
                        dirs.Add(AllDir.Up);
                        dirs.Add(AllDir.Right);
                        dirs.Add(AllDir.Down);
                        dirs.Add(AllDir.Left);

                        dirs.Add(AllDir.UpRight);
                        dirs.Add(AllDir.LeftUp);
                        dirs.Add(AllDir.DownLeft);
                        dirs.Add(AllDir.RightDown);
                    }
                    break;
                case Type.King:
                    {
                        dirs.Add(AllDir.Up);
                        dirs.Add(AllDir.Right);
                        dirs.Add(AllDir.Down);
                        dirs.Add(AllDir.Left);

                        dirs.Add(AllDir.UpRight);
                        dirs.Add(AllDir.LeftUp);
                        dirs.Add(AllDir.DownLeft);
                        dirs.Add(AllDir.RightDown);

                        length = 1;
                    }
                    break;
                case Type.Knight:
                    {
                        dirs.Add(new Point(2, 1));
                        dirs.Add(new Point(-2, 1));
                        dirs.Add(new Point(2, -1));
                        dirs.Add(new Point(-2, -1));

                        dirs.Add(new Point(1, 2));
                        dirs.Add(new Point(-1, 2));
                        dirs.Add(new Point(1, -2));
                        dirs.Add(new Point(-1, -2));

                        length = 1;
                    }
                    break;
            }
        }

        public void Info()
        {
            Console.WriteLine();
            Console.WriteLine(type + "[ " + (point.x + 1) + ", " + (char)(point.y + 97)+ "] " + color + " - " + length);
            Console.WriteLine();
        }

    }
}
