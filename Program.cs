using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace MagicChessBoard
{
    class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board();

            board.RandomPosition();

            board.ShowBoard(board.charTiles, board.boardPieces);

            board.ShowAllPieceMoves(Piece.Color.White);
            foreach (var piece in board.piecesB)
            {
                //board.ShowPiecePotentMoves(piece);
                board.ShowPieceLegalMoves(piece);
            }

            //board.ShowAllPieceMoves(Piece.Color.Black);

        }
    } 
    class G {
        public static string ChangeAnsiColor(string input, int newColorCode)
        {
            // Regex pattern to detect ANSI color codes (e.g., "\u001b[36m")
            string pattern = @"\u001b\[\d+m";

            // Replace the existing color with the new color
            return Regex.Replace(input, pattern, $"\u001b[{newColorCode}m");
        }
    }

    class Board
    {
        static public int SizeX = 8;
        static public int SizeY = 8;

        public List<Piece> piecesW = new List<Piece>();
        public List<Piece> piecesB = new List<Piece>();

        public Piece[,] boardPieces = new Piece[SizeX, SizeY];
        public Piece[,] boardPieces_temp = new Piece[SizeX, SizeY];

        public string[,] charTiles = new string[SizeX, SizeY];

        private Piece KingW;
        private Piece KingB;

        public Board()
        {
        }

        public void Test1()
        {
            Random random = new Random();
            int x, y;

            x = 0; y = 0;

            boardPieces[x, y] = new Piece(Piece.Type.King, Piece.Color.White, new Point(x, y), 1);
            boardPieces_temp[x, y] = new Piece(boardPieces[x, y]);

            piecesW.Add(boardPieces[x, y]);
            KingW = boardPieces[x, y];

            x = 0; y = 3;

            boardPieces[x, y] = new Piece(Piece.Type.Rook, Piece.Color.Black, new Point(x, y), 4);
            boardPieces_temp[x, y] = new Piece(boardPieces[x, y]);

            piecesB.Add(boardPieces[x, y]);

            x = 5; y = 0;

            boardPieces[x, y] = new Piece(Piece.Type.Queen, Piece.Color.Black, new Point(x, y), 7);
            boardPieces_temp[x, y] = new Piece(boardPieces[x, y]);

            piecesB.Add(boardPieces[x, y]);

            x = 7; y = 7;

            boardPieces[x, y] = new Piece(Piece.Type.King, Piece.Color.Black, new Point(x, y), 1);
            boardPieces_temp[x, y] = new Piece(boardPieces[x, y]);

            piecesB.Add(boardPieces[x, y]);
            KingB = boardPieces[x, y];

        }
        public void Test2()
        {
            Random random = new Random();
            int x, y;

            x = 0; y = 0;

            boardPieces[x, y] = new Piece(Piece.Type.King, Piece.Color.White, new Point(x, y), 1);
            boardPieces_temp[x, y] = new Piece(boardPieces[x, y]);

            piecesW.Add(boardPieces[x, y]);
            KingW = boardPieces[x, y];

            x = 0; y = 3;

            boardPieces[x, y] = new Piece(Piece.Type.Rook, Piece.Color.Black, new Point(x, y), 4);
            boardPieces_temp[x, y] = new Piece(boardPieces[x, y]);

            piecesB.Add(boardPieces[x, y]);

            x = 5; y = 5;

            boardPieces[x, y] = new Piece(Piece.Type.Queen, Piece.Color.Black, new Point(x, y), 7);
            boardPieces_temp[x, y] = new Piece(boardPieces[x, y]);

            piecesB.Add(boardPieces[x, y]);

            x = 7; y = 7;

            boardPieces[x, y] = new Piece(Piece.Type.King, Piece.Color.Black, new Point(x, y), 1);
            boardPieces_temp[x, y] = new Piece(boardPieces[x, y]);

            piecesB.Add(boardPieces[x, y]);
            KingB = boardPieces[x, y];
        }
        public void Test3()
        {
            Random random = new Random();
            int x, y;

            x = 0; y = 0;

            boardPieces[x, y] = new Piece(Piece.Type.King, Piece.Color.White, new Point(x, y), 1);
            boardPieces_temp[x, y] = new Piece(boardPieces[x, y]);

            piecesW.Add(boardPieces[x, y]);
            KingW = boardPieces[x, y];

            x = 1; y = 0;

            boardPieces[x, y] = new Piece(Piece.Type.Rook, Piece.Color.White, new Point(x, y), 4);
            boardPieces_temp[x, y] = new Piece(boardPieces[x, y]);

            piecesW.Add(boardPieces[x, y]);

            x = 5; y = 5;

            boardPieces[x, y] = new Piece(Piece.Type.Queen, Piece.Color.Black, new Point(x, y), 7);
            boardPieces_temp[x, y] = new Piece(boardPieces[x, y]);

            piecesB.Add(boardPieces[x, y]);

            x = 7; y = 7;

            boardPieces[x, y] = new Piece(Piece.Type.King, Piece.Color.Black, new Point(x, y), 1);
            boardPieces_temp[x, y] = new Piece(boardPieces[x, y]);

            piecesB.Add(boardPieces[x, y]);
            KingB = boardPieces[x, y];
        }
        public void Test4()
        {
            Random random = new Random();
            int x, y;

            x = 0; y = 0;

            boardPieces[x, y] = new Piece(Piece.Type.King, Piece.Color.White, new Point(x, y), 1);
            boardPieces_temp[x, y] = new Piece(boardPieces[x, y]);

            piecesW.Add(boardPieces[x, y]);
            KingW = boardPieces[x, y];

            x = 1; y = 1;

            boardPieces[x, y] = new Piece(Piece.Type.Bishop, Piece.Color.White, new Point(x, y), 6);
            boardPieces_temp[x, y] = new Piece(boardPieces[x, y]);

            piecesW.Add(boardPieces[x, y]);

            x = 1; y = 0;

            boardPieces[x, y] = new Piece(Piece.Type.Rook, Piece.Color.White, new Point(x, y), 4);
            boardPieces_temp[x, y] = new Piece(boardPieces[x, y]);

            piecesW.Add(boardPieces[x, y]);

            x = 5; y = 5;

            boardPieces[x, y] = new Piece(Piece.Type.Queen, Piece.Color.Black, new Point(x, y), 7);
            boardPieces_temp[x, y] = new Piece(boardPieces[x, y]);

            piecesB.Add(boardPieces[x, y]);

            x = 7; y = 7;

            boardPieces[x, y] = new Piece(Piece.Type.King, Piece.Color.Black, new Point(x, y), 1);
            boardPieces_temp[x, y] = new Piece(boardPieces[x, y]);

            piecesB.Add(boardPieces[x, y]);
            KingB = boardPieces[x, y];
        }
        public void Test5()
        {
            Random random = new Random();
            int x, y;

            x = 0; y = 0;

            boardPieces[x, y] = new Piece(Piece.Type.King, Piece.Color.White, new Point(x, y), 1);
            boardPieces_temp[x, y] = new Piece(boardPieces[x, y]);

            piecesW.Add(boardPieces[x, y]);
            KingW = boardPieces[x, y];

            x = 2; y = 2;

            boardPieces[x, y] = new Piece(Piece.Type.Knight, Piece.Color.White, new Point(x, y), 1);
            boardPieces_temp[x, y] = new Piece(boardPieces[x, y]);

            piecesW.Add(boardPieces[x, y]);

            x = 0; y = 3;

            boardPieces[x, y] = new Piece(Piece.Type.Queen, Piece.Color.Black, new Point(x, y), 7);
            boardPieces_temp[x, y] = new Piece(boardPieces[x, y]);

            piecesB.Add(boardPieces[x, y]);

            x = 7; y = 7;

            boardPieces[x, y] = new Piece(Piece.Type.King, Piece.Color.Black, new Point(x, y), 1);
            boardPieces_temp[x, y] = new Piece(boardPieces[x, y]);

            piecesB.Add(boardPieces[x, y]);
            KingB = boardPieces[x, y];
        }

        public void RandomPosition()
        {
            Random random = new Random();

            int count = random.Next(0, 16);

            int x;
            int y;

            for (int i = 0; i < count; i++)
            {
                int length = random.Next(1, 8);

                x = random.Next(0, SizeX);
                y = random.Next(0, SizeY);

                Piece.Color color = (Piece.Color)(random.Next(0, 100) % 2);
                Piece.Type type = (Piece.Type)(random.Next(0, 100) % 5);
                
                boardPieces[x, y] = new Piece(type, color, new Point(x, y), length);
                boardPieces_temp[x, y] = new Piece(type, color, new Point(x, y), length);

                if (color == Piece.Color.White) piecesW.Add(boardPieces[x, y]);
                else piecesB.Add(boardPieces[x, y]);
            }

            x = random.Next(0, SizeX);
            y = random.Next(0, SizeY);

            boardPieces[x, y] = new Piece(Piece.Type.King, Piece.Color.White, new Point(x, y), 1);
            boardPieces_temp[x, y] = new Piece(boardPieces[x, y]);

            piecesW.Add(boardPieces[x, y]);
            KingW = boardPieces[x, y];

            x = random.Next(0, SizeX);
            y = random.Next(0, SizeY);

            boardPieces[x, y] = new Piece(Piece.Type.King, Piece.Color.Black, new Point(x, y), 1);
            boardPieces_temp[x, y] = new Piece(boardPieces[x, y]);

            piecesB.Add(boardPieces[x, y]);
            KingB = boardPieces[x, y];

            SetUpChars(boardPieces);
        }

        private void SetUpChars(Piece[,] board)
        {
            for (int x = 0; x < SizeX; x++)
            {
                for (int y = 0; y < SizeY; y++)
                {
                    if (board[x, y] == null) charTiles[x, y] = "\u001b[0m.\u001b[0m";
                    else
                    {
                        string color, net = "\u001b[0m";

                        if (board[x, y].color == Piece.Color.White) color = "\u001b[36m";
                        else color = "\u001b[31m";

                        switch (board[x, y].type)
                        {
                            case Piece.Type.Pawn:
                                {
                                    charTiles[x, y] = color + "P" + net;
                                }
                                break;
                            case Piece.Type.Rook:
                                {
                                    charTiles[x, y] = color + "R" + net;
                                }
                                break;
                            case Piece.Type.Bishop:
                                {
                                    charTiles[x, y] = color + "B" + net;
                                }
                                break;
                            case Piece.Type.Queen:
                                {
                                    charTiles[x, y] = color + "Q" + net;
                                }
                                break;
                            case Piece.Type.King:
                                {
                                    charTiles[x, y] = color + "K" + net;
                                }
                                break;
                            case Piece.Type.Knight:
                                {
                                    charTiles[x, y] = color + "N" + net;
                                }
                                break;
                        }
                    }
                }
            }
        }

        public void ShowBoard(string[,] tiles, Piece[,] board)
        {
            SetUpChars(board);

            Console.WriteLine("+ a b c d e f g h");

            for (int x = 0; x < SizeX; x++)
            {
                Console.Write(x + 1);

                for (int y = 0; y < SizeY; y++)
                {
                    Console.Write(" ");
                    Console.Write(tiles[x, y]);
                }

                Console.Write("\n");
            }
        }

        private void Board_TempMove(Piece piece, Point move)
        {
            boardPieces_temp[piece.point.x, piece.point.y] = null;
            boardPieces_temp[move.x, move.y] = piece;
            piece.point = move;
        }

        private void Board_ReturnMove(Piece piece, Point move)
        {
            Piece temp_piece = boardPieces[piece.point.x, piece.point.y];
            if (temp_piece != null) boardPieces_temp[piece.point.x, piece.point.y] = new Piece(temp_piece);
            else boardPieces_temp[piece.point.x, piece.point.y] = null;

            temp_piece = boardPieces[move.x, move.y];
            if (temp_piece != null) boardPieces_temp[move.x, move.y] = new Piece(temp_piece);
            else boardPieces_temp[move.x, move.y] = null;

            piece.point = move;
        }

        private bool KingSave(Piece.Color color)
        {
            for (int x = 0; x < SizeX; x++)
            {
                for (int y = 0; y < SizeY; y++)
                {
                    if (boardPieces_temp[x, y] == null) continue;
                    if (boardPieces_temp[x, y].color == color) continue;

                    if (color == Piece.Color.Black) if (PotentMove(boardPieces_temp[x, y], boardPieces_temp).Contains(KingB.point)) return false;
                    if (color == Piece.Color.White) if (PotentMove(boardPieces_temp[x, y], boardPieces_temp).Contains(KingW.point)) return false;
                }
            }

            return true;
        }

        private List<Point> PotentMove(Piece piece, Piece[,] board)
        {
            List<Point> potent_moves = new List<Point>();

            Point ocupPos = piece.point;
            Point nextPos = piece.point;

            foreach (var dir in piece.dirs)
            {
                for (int i = 1; i <= piece.length; i++)
                {
                    nextPos.x = i * dir.x + ocupPos.x;
                    nextPos.y = i * dir.y + ocupPos.y;

                    // from there 
                    if (nextPos.x >= SizeX || nextPos.x < 0 || nextPos.y >= SizeY || nextPos.y < 0) break; 
                    else if (board[nextPos.x, nextPos.y] != null && board[nextPos.x, nextPos.y].color == piece.color) break; 
                    else if (board[nextPos.x, nextPos.y] != null && board[nextPos.x, nextPos.y].color != piece.color) { potent_moves.Add(nextPos); break; } 
                    else potent_moves.Add(nextPos);

                    // to there potetial moves
                }
            }

            return potent_moves;
        }

        private List<Point> LegalMove(Piece piece, List<Point> potent_moves)
        {
            List<Point> legal_moves = new List<Point>();
            Point startPos = piece.point;

            foreach (var move in potent_moves)
            {
                // take move
                Board_TempMove(piece, move);
                
                //ShowBoard(charTiles, boardPieces_temp);

                // check king save And add move
                if (KingSave(piece.color))legal_moves.Add(move); 

                // return state
                Board_ReturnMove(piece, startPos);
                
                SetUpChars(boardPieces);
            }

            

            return legal_moves;
        }

        public void ShowPiecePotentMoves(Piece piece)
        {
            piece.Info();

            Point ocupPos = piece.point;

            List<Point> potent_moves = PotentMove(piece, boardPieces);

            string[,] tempCharTiles = charTiles.Clone() as string[,];
            tempCharTiles[ocupPos.x, ocupPos.y] = G.ChangeAnsiColor(tempCharTiles[ocupPos.x, ocupPos.y], 33) + "\u001b[0m";

            foreach (var pos in potent_moves)
            {
                tempCharTiles[pos.x, pos.y] = G.ChangeAnsiColor(tempCharTiles[pos.x, pos.y], 33) + "\u001b[0m";
            }

            ShowBoard(tempCharTiles, boardPieces);
        }

        public void ShowPieceLegalMoves(Piece piece)
        {
            piece.Info();

            Point ocupPos = piece.point;

            List<Point> potent_moves = PotentMove(piece, boardPieces);
            List<Point> legal_moves = LegalMove(piece, potent_moves);

            string[,] tempCharTiles = charTiles.Clone() as string[,];
            tempCharTiles[ocupPos.x, ocupPos.y] = G.ChangeAnsiColor(tempCharTiles[ocupPos.x, ocupPos.y], 32) + "\u001b[0m";

            foreach (var pos in legal_moves)
            {
                tempCharTiles[pos.x, pos.y] = G.ChangeAnsiColor(tempCharTiles[pos.x, pos.y], 32) + "\u001b[0m";
            }

            ShowBoard(tempCharTiles, boardPieces);
        }

        public void ShowAllPieceMoves(Piece.Color color)
        {
            string[,] tempCharTiles = charTiles.Clone() as string[,];

            List<Piece> pieces = new List<Piece>();
            if (color == Piece.Color.White) pieces = piecesW;
            else if (color == Piece.Color.Black) pieces = piecesB;

            foreach (var piece in pieces)
            {
                Point ocupPos = piece.point;

                List<Point> potent_moves = PotentMove(piece, boardPieces);
                List<Point> legal_moves = LegalMove(piece, potent_moves);

                
                tempCharTiles[ocupPos.x, ocupPos.y] = G.ChangeAnsiColor(tempCharTiles[ocupPos.x, ocupPos.y], 33) + "\u001b[0m";

                foreach (var pos in legal_moves)
                {
                    tempCharTiles[pos.x, pos.y] = G.ChangeAnsiColor(tempCharTiles[pos.x, pos.y], 33) + "\u001b[0m";
                }
            }

            ShowBoard(tempCharTiles, boardPieces);
        }


    }
}
