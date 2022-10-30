let num = 565;
let num1 = 0;
for (let i = 1; num >= i; i++)
{
    if (num%i == 0)
    {
        num1++;
    }
}
if (num1 == 2)
{
    console.log("eded sadedir");
}
else if (num == 1 || num == 0)
{
    console.log("eded ne sadedir, ne murekkebdir");
}
else 
{
    console.log("eded murekkebdir");
}