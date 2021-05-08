﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuildingZone
{
    public delegate void BuildPart();
    public enum Material
    {
        glass = 1,
        wooden,
        metallic,
    }
    public class House
    {
        BuildPart buildPart;
        static void DrawBasement()
        {
            for (int i = 0; i < 11; i++)
            {
                for (int j = 0; j < 11; j++)
                {
                    Console.SetCursorPosition(i, 11);
                    Console.Write("=");
                }
            }
        }

        static void DrawWall()
        {
            for (int i = 6; i < 11; i++)
            {
                for (int j = 6; j < 11; j++)
                {
                    Console.SetCursorPosition(0, j);
                    Console.Write("|");
                    Console.SetCursorPosition(10, j);
                    Console.Write("|");
                }
            }
        }
        static void DrawRoof()
        {
            bool chSideHap = false;
            int y = 5;
            for (int i = 0; i < 11; i++)
            {

                Console.SetCursorPosition(i, y);

                if (y == 0)
                {
                    chSideHap = true;
                }

                if (!chSideHap)
                {
                    Console.Write("/");
                    y--;
                }
                else
                {
                    Console.Write("\\");

                    y++;
                }

            }
        }

        static void DrawWindow()
        {
            for (int i = 2; i < 5; i++)
            {
                for (int j = 7; j < 10; j++)
                {

                    Console.SetCursorPosition(i, j);
                    
                    if(i == 3 && j == 8)
                        Console.Write(" ");
                    else
                        Console.Write("*");
                }
            }
        }
        static void DrawDoor()
        {
            for (int i = 7; i < 10; i++)
            {
                for (int j = 7; j < 11; j++)
                {

                    Console.SetCursorPosition(i, j);

                    if (i == 8 && (j >= 8 && j <= 10))
                        Console.Write(" ");
                    else
                        Console.Write("*");
                }
            }
        }

        public void AddBasement()
        {
            buildPart += DrawBasement;
        }
        public void AddWall()
        {
            buildPart += DrawWall;
        }
        public void AddRoof()
        {
            buildPart += DrawRoof;
        }
        public void AddWindow()
        {
            buildPart += DrawWindow;
        }
        public void AddDoor()
        {
            buildPart += DrawDoor;
        }

        public void DrawHouse()
        {
            buildPart.Invoke();
        }
    }
}
