using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomInterface
{
    abstract class Shape
    {
        public Shape(string name = "NoName")
        {
            PetName = name;
        }

        public string PetName { get; set; }
        
        //method
        public abstract void Draw();
    }


    // different shape classes
    class Circle : Shape
    {
        public Circle() { }

        public Circle(string name) : base(name)
        {
        }

        public override void Draw()
        {
            Console.WriteLine("Drawing {0} the Circle", PetName);
        }
    }

    class Hexagon : Shape, IPointy, IDraw3D
    {
        public Hexagon() { }
        public Hexagon(string name) : base(name) { }

        public override void Draw()
        {
            Console.WriteLine("Drawing {0} the Hexagon", PetName);
        }

        public byte Points
        { get { return 6; } }

        public void Draw3D()
        {
            Console.WriteLine($"Drawing Hexagon ({PetName}) in 3D!");
        }
    }

    class Triangle : Shape, IPointy
    {
        public Triangle()
        {
        }

        public Triangle(string name) : base(name)
        {
        }

        public override void Draw()
        {
            Console.WriteLine($"Drawing {PetName} the Triangle");
        }

        public byte Points
        {
            get { return 3; }
        }
    }
}
