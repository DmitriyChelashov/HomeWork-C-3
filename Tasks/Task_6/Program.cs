// Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел
void print (int [] A)
{
    int l = A.Length;
    int i = 0;
    while (i < l)
    {
        Console.Write (A [i] + " ");
        i++;
    }
}
void fill (int [] A)
{
    int l = A.Length;
    int i = 0;
    while (i < l)
    {
        A [i] = new Random().Next(100, 1000);
        i++; 
    }
}

int [] array = new int [10];
fill (array);
print (array);
Console.WriteLine (" ");

int i = 0;
int sum1 = 0;
int l = array.Length;
while (i < l)
{
    if (array [i] % 2 == 0)
    sum1 = sum1 + 1;
    i++;
}
Console.WriteLine ("Количество четных чисел равно " + sum1);


int sum2 = 0;
int j = 0;
while (j < l)
{
    if (array [j] % 2 != 0)
    sum2 = sum2 + 1;
    j++;
}
Console.WriteLine ("Количество нечетных чисел равно " + sum2);