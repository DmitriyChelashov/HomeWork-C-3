// Определить, присутствует ли в заданном массиве, некоторое число
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
int [] array = new int [10];
fill (array);
print (array);
Console.WriteLine (" ");
Console.WriteLine ("Введите число для поиска его в массиве: ");
int x = int.Parse (Console.ReadLine ());

 void obnl (int [] A)
{
    int l = A.Length;
    int i = 0;
    bool contains = false;
    while (i < l)
    {
        if (A [i] == x)
        {Console.WriteLine ("Да, заданное число есть в массиве!");
        contains = true;
        break;}
        i++; 
    }
    if (contains == false)
Console.WriteLine ("Числа нет в массиве!");
}
obnl (array);



