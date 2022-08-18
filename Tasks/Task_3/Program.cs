// Найти сумму положительных/отрицательных элементов массива
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
        A [i] = new Random().Next(-99, 100);
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
    if (array [i] > 0)
    sum1 = sum1 + array [i];
    i++;
}
Console.WriteLine ("Сумма положительных элементов массива равна " + sum1);


int sum2 = 0;
int j = 0;
while (j < l)
{
    if (array [j] < 0)
    sum2 = sum2 + array [j];
    j++;
}
Console.WriteLine ("Сумма отрицательных элементов массива равна " + sum2);