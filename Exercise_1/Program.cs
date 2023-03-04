Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("Наш массив состоит из чисел: ");
PrintArray(numbers);
int count = 0;

for (int z = 0; z < numbers.Length; z++)
if (numbers[z] % 2 == 0)
count++;

Console.WriteLine($"Всего {numbers.Length} чисел, из них четных: {count}");

void FillArrayRandomNumbers(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100, 1000);
    }
}
void PrintArray(int[] numbers)
{
    
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    
    Console.WriteLine();
}
