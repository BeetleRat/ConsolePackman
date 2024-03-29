﻿namespace ConsolePackman
{
    public class Maps
    {
        public static readonly char W = '#'; // Wall
        public static readonly char X = 'x'; // Price
        public static readonly char _ = ' '; // Empty
        public static readonly char OpenX = 'O'; // Open price

        public static readonly char[,] MAP1 =
        {
            { W, W, W, W, W, W, W, W, W, W, W, W, W, W, W, W, W, W, W, W, W },
            { W, _, W, _, _, _, _, _, _, _, _, _, _, _, _, _, W, _, _, _, W },
            { W, _, W, _, _, _, _, _, _, _, _, W, _, _, _, _, W, _, X, _, W },
            { W, _, W, _, W, W, W, W, _, _, _, W, _, _, _, _, _, _, _, _, W },
            { W, _, W, _, _, _, _, W, _, _, _, W, _, _, _, _, _, _, _, _, W },
            { W, _, _, _, _, _, _, W, _, _, _, W, _, _, _, _, _, _, _, _, W },
            { W, W, W, W, _, _, _, _, _, _, _, W, W, W, W, W, W, W, W, W, W },
            { W, _, _, W, _, X, _, _, W, _, _, W, _, _, _, _, _, _, _, _, W },
            { W, _, _, W, _, _, _, W, W, W, _, W, _, _, _, _, _, _, _, _, W },
            { W, _, W, W, _, _, _, _, W, X, _, W, _, _, _, _, _, _, _, _, W },
            { W, _, _, _, _, _, _, _, _, _, _, W, _, _, _, _, _, X, _, _, W },
            { W, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, W },
            { W, _, W, W, W, W, W, W, _, W, W, W, W, W, W, W, _, _, _, _, W },
            { W, _, _, _, _, _, _, W, _, _, _, _, W, _, W, _, _, _, _, _, W },
            { W, _, _, _, _, _, _, W, _, _, _, _, W, _, _, _, _, _, _, _, W },
            { W, _, _, _, X, _, _, W, _, _, _, _, W, _, W, W, W, W, W, _, W },
            { W, _, _, _, _, _, _, W, _, X, _, _, W, _, W, _, _, _, W, _, W },
            { W, _, _, _, _, _, _, W, _, _, _, _, W, _, _, _, W, _, W, _, W },
            { W, W, W, W, W, W, W, W, W, W, W, W, W, W, W, W, W, W, W, W, W }
        };

        public static readonly char[,] WIN_MAP =
        {
            { _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _ },
            { X, X, _, _, X, X, _, _, _, _, X, X, X, X, _, _, _, X, X, _, _, _, _, X, X, _, _ },
            { X, X, X, X, X, X, _, _, X, X, _, _, _, _, X, X, _, X, X, _, _, _, _, X, X, _, _ },
            { _, _, X, X, _, _, _, _, X, X, _, _, _, _, X, X, _, X, X, _, _, _, _, X, X, _, _ },
            { _, _, X, X, _, _, _, _, X, X, _, _, _, _, X, X, _, X, X, _, _, _, _, X, X, _, _ },
            { _, _, X, X, _, _, _, _, _, _, X, X, X, X, _, _, _, _, _, X, X, X, X, _, _, _, _ },
            { _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _ },
            { _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _ },
            { X, X, _, _, _, _, _, _, X, X, _, _, X, X, _, _, _, X, X, _, _, _, _, _, _, X, X },
            { X, X, _, _, X, X, _, _, X, X, _, _, _, _, _, _, _, X, X, X, X, _, _, _, _, X, X },
            { X, X, _, _, X, X, _, _, X, X, _, _, X, X, _, _, _, X, X, _, _, X, X, _, _, X, X },
            { X, X, X, X, X, X, X, X, X, X, _, _, X, X, _, _, _, X, X, _, _, _, _, X, X, X, X },
            { _, _, X, X, _, _, X, X, _, _, _, _, X, X, _, _, _, X, X, _, _, _, _, _, _, X, X },
            { _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _ },
            { _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _ },
            { _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _, _ }
        };
    }
}