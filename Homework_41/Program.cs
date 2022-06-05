
Console.Write("Введите отрицательные или положительные через пробел: ");
int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array [i] > 0)
    {
        count++;
    }
}
Console.WriteLine ($"Количество чисел больше нуля, введенных пользователем = {count}");