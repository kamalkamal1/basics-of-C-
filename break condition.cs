﻿using System;
public class Program
{
    public static void Main()
    {
        int i = 0;
        while (i < 10)
        {
            Console.WriteLine(i);
            i++;
            if (i == 4)
            {
                break;
            }
        }
    }
}