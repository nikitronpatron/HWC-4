// принимает на вход число
// выдаёт сумму цифр в числе

int AddDigitsNumber(int num)
{
    int result = 0;
    while(num != 0)
    {
        result = result + num % 10;
        num = num / 10;
    }
    return result;
}

int number = Convert.ToInt32(Console.ReadLine());
int sum = AddDigitsNumber(number);
Console.WriteLine(sum);