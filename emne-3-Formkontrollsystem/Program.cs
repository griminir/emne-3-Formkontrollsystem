// See https://aka.ms/new-console-template for more information

using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using emne_3_Formkontrollsystem;

Console.WriteLine("Formkontrollsystem");

List<Shape> allShapes  = new List<Shape>()
{
    new Circle("circle1", "green", 5),
    new Circle("circle2", "red", 8),
    new Rectangle("rectangle1", "yellow", 5, 5),
    new Rectangle("rectangle2", "green", 7, 9),
    new Triangle("triangle1", "green", 15, 32),
    new Triangle("triangle2", "yellow", 4, 7)
};

void DisplayList(List<Shape> listtosort)
{
    foreach (var shape in listtosort)
    {
        Console.WriteLine($"Name: {shape.Name} Color: {shape.Color} Areal: {shape.Areal}m^2");
    }
}

void TotalAreal(List<Shape> list)
{
    decimal sum = 0;
    foreach (var shape in list)
    {
        sum += shape.Areal;
    }

    Console.WriteLine($"total areal = {sum}m^2");
}

void SortedListByAreal(List<Shape> list)
{
    var sortedShapes = list.OrderBy(p => p.Areal).ToList();
    DisplayList(sortedShapes);
}

void FilterListColor(List<Shape> theList, string color)
{
    var ListFiltered = theList.Where(c => c.Color.Contains(color)).ToList();
    DisplayList(ListFiltered);
}

DisplayList(allShapes);
TotalAreal(allShapes);
Console.WriteLine();
SortedListByAreal(allShapes);
Console.WriteLine();
FilterListColor(allShapes, "green");
Console.WriteLine();
FilterListColor(allShapes, "yellow");