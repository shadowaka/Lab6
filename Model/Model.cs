using System;
namespace Lab6.Model;
internal class MyModel
{
    public double CalcArea(string figure)
    {
        double area = 0;
        if (figure == "Квадрат")
        {
            area = 3 * 4;
        }
        else { area = (Math.Sqrt(3) / 4) * Math.Pow(3,2); }
        return area;
    }
}