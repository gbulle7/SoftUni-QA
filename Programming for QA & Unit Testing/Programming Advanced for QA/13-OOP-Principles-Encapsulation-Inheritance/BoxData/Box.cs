﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata;
using System.Text;

namespace BoxData;

public class Box
{
    private double length;
    private double width;
    private double height;

    public Box(double length, double width, double height)
    {
        Length = length;
        Width = width;
        Height = height;
    }

    public double Length
    {
        get => length;
        private set
        {
            if (value <= 0)
            {
                throw new ArgumentOutOfRangeException($"Length cannot be zero or negative");
            }
            length = value;
        }
    }
    public double Width
    {
        get => width;
        private set
        {
            if (value <= 0)
            {
                throw new ArgumentOutOfRangeException("Width cannot be zero or negative");
            }
            width = value;
        }
    }
    public double Height
    {
        get => height;
        private set
        {
            if (value <= 0)
            {
                throw new ArgumentOutOfRangeException("Height cannot be zero or negative");
            }
            height = value;
        }
    }

    public double SurfaceArea()
    {
        return 2 * Length * Width + 2 * Length * Height + 2 * Width * Height;
    }

    public double Volume()
    {
        return Length * Width * Height;
    }

    public override string ToString()
    {
        return $"Surface Area - {SurfaceArea():F2}{Environment.NewLine}Volume - {Volume():F2}";
    }
}
