// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int [] array= new int [900];

int count=0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100,1000);
    System.Console.Write(array[i]+ " "); 

    if (array[i]%2==0)
    {
        count++;
    }
}
System.Console.WriteLine("Кол-во равно "+ count);

// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int [] array= new int [10];
int sum = 0;
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next();
    System.Console.Write(array[i]+ " ");
}
for (int i = 1; i < array.Length; i+=2)
{
    sum+=array[i];
}
System.Console.WriteLine("Сумма "+ sum);

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double [] numbers= new double [10];
for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = new Random().NextDouble();
    System.Console.WriteLine(numbers[i]+ " ");
}

double max = numbers[0];
double min = numbers[0];

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > max)
    {
        max = numbers[i];
    }
    else if (numbers[i] < min)
    {
        min = numbers[i];
    }
}
Console.WriteLine("Минимальное число "+min);
Console.WriteLine("Максимальное число "+max);
Console.WriteLine("Разница между максимальным и минимальным числами: " +(max-min));

