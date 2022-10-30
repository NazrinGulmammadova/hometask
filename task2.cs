int num = 220022;
int qaliq;
int mun;
int num1 = 0;
mun = num;
while (num > 0)
{
    qaliq = num % 10;
    num1 = (num1 * 10) + qaliq;
    num = num / 10;
}
if (mun == num1)
{
    Console.WriteLine("it is polindrome");
}
else
{
    Console.WriteLine("it is not polindrome");
}