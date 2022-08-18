// Задать массив из 12 элементов, заполненных числами из [0,9].
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
        A [i] = new Random().Next(0, 10);
        i++; 
    }
}

int [] array = new int [12];
fill (array);
print (array);

int sum = 0;
while (i < l)
{
    int sum = sum + A [i];
    i++;
}
