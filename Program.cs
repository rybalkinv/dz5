int programm, num;
Boolean begin = true;
 
while (begin)
{
Console.WriteLine("------");
Console.WriteLine("Введите число для соответствующей задачи или иное для выхода:");
Console.WriteLine("1. Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.");
Console.WriteLine("2. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.");
Console.WriteLine("3. Напишите программу, которая задаёт массив из N элементов и выводит их на экран.");
programm = Convert.ToInt32(Console.ReadLine());
 
switch (programm)
{
case 1:
// Задайте массив заполненный случайными положительными трехзначными числами.
// Напишите программу, которая покажет количество четных чисел в массиве.
// [345, 897, 568, 234] => 2
Console.WriteLine("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("массив: ");
PrintArray(numbers);
int count = 0;
 
for (int z = 0; z < numbers.Length; z++)
if (numbers[z] % 2 == 0)
count++;
 
Console.WriteLine($"всего {numbers.Length} чисел, {count} из них чётные");
 
void FillArrayRandomNumbers(int[] numbers)
{
for(int i = 0; i < numbers.Length; i++)
{
numbers[i] = new Random().Next(100,1000);
}
}
void PrintArray(int[] numbers)
{
Console.Write("[ ");
for(int i = 0; i < numbers.Length; i++)
{
Console.Write(numbers[i] + " ");
}
Console.Write("]");
Console.WriteLine();
}

break;

case 2:
// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечетных позициях.
// [3, 7, 23, 12] => 19
// [-4, -6, 89, 6] => 0
Console.WriteLine("Введите размер массива ");
int size1 = Convert.ToInt32(Console.ReadLine());
int[] numbers1 = new int[size1];
FillArrayRandomNumbers(numbers1);
Console.WriteLine("массив: ");
PrintArray(numbers1);
int sum = 0;
 
for (int z = 0; z < numbers1.Length; z+=2)
sum = sum + numbers1[z];
 
Console.WriteLine($"всего {numbers1.Length} чисел, сумма элементов cтоящих на нечётных позициях = {sum}");
 
void FillArrayRandomNumbers1(int[] numbers)
{
for(int i = 0; i < numbers.Length; i++)
{
numbers[i] = new Random().Next(1,10);
}
}
void PrintArray1(int[] numbers)
{
Console.Write("[ ");
for(int i = 0; i < numbers.Length; i++)
{
Console.Write(numbers[i] + " ");
}
Console.Write("]");
Console.WriteLine();
}

break;


case 3:
// Задайте с клавиатуры массив ыещественных (double) чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// Задать размер (int) массива с клавиатуры
// [3 7 22 2 78] => 76
 
Console.WriteLine("Введите размер массива ");
int size12 = Convert.ToInt32(Console.ReadLine());
double[] numbers12 = new double[size12];
FillArrayRandomNumbers12(numbers12);
Console.WriteLine("массив: ");
PrintArray12(numbers12);
double min = Int32.MaxValue;
double max = Int32.MinValue;
 
for (int z = 0; z < numbers12.Length; z++)
{
if (numbers12[z] > max)
{
max = numbers12[z];
}
if (numbers12[z] < min)
{
min = numbers12[z];
}
}
 
Console.WriteLine($"всего {numbers12.Length} чисел. Максимальное значение = {max}, минимальное значение = {min}");
Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");
 
void FillArrayRandomNumbers12(double[] numbers12)
{
for(int i = 0; i < numbers12.Length; i++)
{
numbers12[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
}
}
void PrintArray12(double[] numbers12)
{
Console.Write("[ ");
for(int i = 0; i < numbers12.Length; i++)
{
Console.Write(numbers12[i] + " ");
}
Console.Write("]");
Console.WriteLine();
}
break;

default:
begin = false;
break;
}
}
