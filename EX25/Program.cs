// принимает на вход два числа (A и B)
// возводит число A в натуральную степень B

int Exponentiation(int a, int b)
{
    int result = 1;
    for(int i = 0; i < b; i++)
    {
        result = result * a;
    }
    return result;
}

int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());
int exp = Exponentiation(x, y);
Console.WriteLine(exp);