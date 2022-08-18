// Написать программу замену элементов массива на противоположные
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
void obnl (int [] A)
{
    int l = A.Length;
    int i = 0;
    while (i < l)
    {
        A [i] = - A [i];
        i++; 
    }
}
int [] array = new int [10];
fill (array);
print (array);
Console.WriteLine ( );
obnl (array);
print (array);

