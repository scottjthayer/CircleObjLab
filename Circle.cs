using System;
using System.Collections.Generic;
using System.Text;

namespace Circle_Objects_Lab
{
    class Circle
    {

        public double Radius;
        
        public Circle(double radius)
        {
            Radius = radius;
        }
        private double radius
        {
            get { return Radius; }      
        }
        
        public double CalculateCircumference()
        {
           
            double circumference = 2 * Math.PI * radius;
            return circumference;
        }
        public string CalculateFormattedCircumference()
        {
            double circumference = CalculateCircumference();
            string cirForm = FormatNumber(circumference);
            return cirForm;
        }

        public double CalculateArea()
        {

            double area = Math.PI * (radius * radius);
            return area;
        }

        public string CalculateFormattedArea()
        {
            double area = CalculateArea();
            string areaForm = FormatNumber(area);
            return areaForm;
        }

        private string FormatNumber(double x)
        {
            string format = string.Format("{0:0.00}", x);
            return format;
        }






    }
}
