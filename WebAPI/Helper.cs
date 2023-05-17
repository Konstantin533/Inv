namespace WebAPI
{
    public static class Helper
    {
        public static List<Shape> GenerateRandomShape(int count)
        {
            var shapes = new List<Shape>();
            var random = new Random();
            for (int i = 0; i < count; i++)
            {
                var shape = new Shape();
                shape.Id = Guid.NewGuid().ToString();
                shape.Name = GenerateRandomShape();
                if (shape.Name.Equals("Circle"))
                {
                    shape.Radius = GenerateRandomRadius();
                    shape.Height = "Я круг, у меня нет сторон";
                }
                else
                {
                    shape.Radius = "Я не круг, у меня не может быть радиуса";
                    shape.Height = GenerateRandomRadius();
                }

                shapes.Add(shape);
            }
            return shapes;
        }
        public static string GenerateRandomShape()
        {
            string[] names = { "Circle", "Triangle", "Square", "Rectangle", "Rhombus" };
            var random = new Random();

            int index = random.Next(0, names.Length);
            return names[index];
        }
        public static string GenerateRandomRadius()
        {
            string[] radius = { "20", "24", "12", "17", "10", "7", "35", "26", "36", "51" };
            var random = new Random();

            int index = random.Next(0, radius.Length);
            return radius[index];
        }
    }
}
