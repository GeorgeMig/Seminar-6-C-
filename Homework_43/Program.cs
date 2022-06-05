Console.Write("Введите b1 =>");
int b1 = int.Parse(Console.ReadLine());
Console.Write("Введите k1 =>");
int k1 = int.Parse(Console.ReadLine());
Console.Write("Введите b2 =>");
int b2 = int.Parse(Console.ReadLine());
Console.Write("Введите k2 =>");
int k2 = int.Parse(Console.ReadLine());

double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;
Console.WriteLine($"Координаты точки пересечения = {x}, {y}");
