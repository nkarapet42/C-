using MyArea;
using System;
using System.ComponentModel.Design;
using System.Diagnostics;

namespace UnitTest
{
    class Program
    {
        public static void Reaload()
        {
            Console.ReadKey();
            Console.Clear();
            Main();
        }

        public static void Main()
        {
            Console.Write("Choose the mode (1-> Enter your numbers, 2-> UnitTest, 3-> Exit): ");
            string tmp = Console.ReadLine();
            try
            {
                int mode = int.Parse(tmp);
                if (mode == 2)
                {
                    Console.WriteLine("*" + new string('#', 45) + "*");
                    try
                    {
                        Triangle point = new Triangle(4, 3, 5);
                        Triangle.CheckRightTriangle(point);
                    }
                    catch (Exception e) { Console.WriteLine(e.Message); }
                    try
                    {
                        Triangle point = new Triangle(45, 57, 27);
                        Console.WriteLine("Area of Triangle: " + Triangle.AreaOfTriangle(point));
                        Triangle.CheckRightTriangle(point);
                    }
                    catch (Exception e) { Console.WriteLine(e.Message); }
                    try
                    {
                        Console.WriteLine(Triangle.AreaOfTriangle(null));
                    }
                    catch (Exception e) { Console.WriteLine(e.Message); }
                    try
                    {
                        Console.WriteLine(Triangle.AreaOfTriangle(new Triangle(45, 57, 0)));
                    }
                    catch (Exception e) { Console.WriteLine(e.Message); }
                    try
                    {
                        Console.WriteLine(Triangle.AreaOfTriangle(new Triangle(45, 57, 786)));
                    }
                    catch (Exception e) { Console.WriteLine(e.Message); }
                    Console.WriteLine("*" + new string('#', 45) + "*");
                    Console.Write(new string('\n', 3));
                    Console.WriteLine("*" + new string('#', 45) + "*");
                    try
                    {
                        Console.WriteLine("Area of Circle: " + Circle.AreaOfCircle(new Circle(4)));
                    }
                    catch (Exception e) { Console.WriteLine(e.Message); }
                    try
                    {
                        Console.WriteLine(Circle.AreaOfCircle(new Circle(-5)));
                    }
                    catch (Exception e) { Console.WriteLine(e.Message); }
                    try
                    {
                        Console.WriteLine(Circle.AreaOfCircle(null));
                    }
                    catch (Exception e) { Console.WriteLine(e.Message); }
                    Console.WriteLine("*" + new string('#', 45) + "*");
                    Reaload();
                }
                else if (mode == 1)
                {
                    string status = "";
                    while (status.ToUpper() != "EXIT")
                    {
                        Console.WriteLine("Command's for clear (CLEAN) or exit (EXIT)");
                        Console.Write("Create treangle (1) or circle (2): Enter the number : ");
                        string temp = Console.ReadLine();
                        if (temp == "1")
                        {
                            try
                            {
                                Console.Write("Enter side A: ");
                                double sideA = double.Parse(Console.ReadLine());
                                Console.Write("Enter side B: ");
                                double sideB = double.Parse(Console.ReadLine());
                                Console.Write("Enter side C: ");
                                double sideC = double.Parse(Console.ReadLine());

                                Triangle triangle = new Triangle(sideA, sideB, sideC);
                                Console.WriteLine("Area of Triangle: " + Triangle.AreaOfTriangle(triangle));
                                Triangle.CheckRightTriangle(triangle);
                            }
                            catch (Exception e) { Console.WriteLine(e.Message + ", press any key to continue"); Console.ReadKey(); Console.Clear(); }
                        }
                        else if (temp == "2")
                        {
                            try
                            {
                                Console.Write("Enter radius: ");
                                double radius = double.Parse(Console.ReadLine());

                                Circle circle = new Circle(radius);
                                Console.WriteLine($"Area of Circle {Circle.AreaOfCircle(circle)}");
                            }
                            catch (Exception e) { Console.WriteLine(e.Message + ", press any key to continue"); Console.ReadKey(); Console.Clear(); }
                        }
                        else if (temp.ToUpper() == "CLEAN")
                            Console.Clear();
                        else if (temp.ToUpper() != "EXIT")
                            Console.WriteLine("Invalid given command, please try again");
                        status = temp;
                    }
                }
                else if (mode == 3)
                    return;
                else
                {
                    Console.WriteLine("Invalid given command, press any key to try again");
                    Reaload();
                }
            } 
            catch (Exception e) 
            { 
                Console.WriteLine($"Invalid command {tmp} , press any key to try again");
                Reaload();
            }
        }
    }
}