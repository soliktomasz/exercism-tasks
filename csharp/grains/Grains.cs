using System;
using System.Collections;

public static class Grains
{
    public static ulong Square(int n)
    {
        if (n < 1 || n > 64) throw new ArgumentOutOfRangeException();

        var chessBoard = GetChessBoard();

        return (ulong)chessBoard[n];
    }

    public static ulong Total()
    {
        var chessBoard = GetChessBoard();
        ulong value = 0;

        for (var i = 1; i <= chessBoard.Count; i++)
        {
            value += (ulong)chessBoard[i];
        }

        return value;

    }

    private static Hashtable GetChessBoard()
    {
        ulong value = 1;

        var chessBoard = new Hashtable
        {
            { 1, value }
        };

        for (var i = 2; i <= 64; i++)
        {
            value *= 2;
            chessBoard.Add(i, value);
        }

        return chessBoard;
    }
}