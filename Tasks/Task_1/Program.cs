// Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран
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
        A [i] = new Random().Next(0, 2);
        i++; 
    }
}

int [] array = new int [8];
fill (array);
print (array);

