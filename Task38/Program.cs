// Задача 38: Задайте массив вещественных чисел. т.е дробные
// Найдите разницу между максимальным и минимальным элементов массива.

Console.WriteLine("Введите размер рандомного массива  ");
int size = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("Массив: ");
PrintArray(numbers);
double min = Int32.MaxValue;
double max = Int32.MinValue;

foreach (global::System.Double v in numbers)
{
    if (v > max)
        {
            max = v;
        }
    if (v < min)
        {
            min = v;
        }
}

Console.WriteLine($"Всего чисел - {numbers.Length} . Максимальное значение = {max}, минимальное значение = {min}");
Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");

void FillArrayRandomNumbers(double[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
        }
}
void PrintArray(double[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}