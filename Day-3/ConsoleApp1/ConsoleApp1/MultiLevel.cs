using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Shape
    {
        //hidden values  fields
        double a_width;
        double a_length;

        //constructor
        public Shape()
        {
            Width = Length = 0.0;
        }
        public Shape(double w, double l)
        {
            Width=w;
            Length=l;

        }
        //properties
        public double Width
        {
            //getter
            get
            {
                return a_width;
            }
            //setter
            set
            {
                a_width = value;
            }
        }
        public double Length
        {  //getter
            get
            {
                return a_length;
            }
            //setter
            set
            {
                a_length = value;
            }
        }
        public void DisplayDim()
        {
            Console.WriteLine("width and length are " + Width + "and " + Length);
        }
    }
    class Rectange : Shape
    {
        string Style;

        public Rectange()
        {
            Style = "null";
        }
        //parameterized constructor
        public Rectange(string s,double w,double l):base(w,l)
        {
            Style = s;
        }
        ////contruct a squre
        //public Rectange()
        public void DisplayStyle()
        {
            Console.WriteLine("Style is " + Style);
        }
    }
    class ColorRectangle : Rectange
    {
        string rcolor;
        public ColorRectangle(string c,string s,double w,double l):base(s,w,l)
        {
            
            rcolor = c;
        }
        public void DisplayColor()
        {
            Console.WriteLine("Color is "+rcolor);
        }
    }
    internal class MultiLevel
    {
        public static void Main()
        {
            ColorRectangle r1 = new ColorRectangle("black","Rectangle",2.0,3.0);
            Console.WriteLine("Details of r1:");
            r1.DisplayStyle();
            r1.DisplayDim();
            r1.DisplayColor();
        }
    }
}
