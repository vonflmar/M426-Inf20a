namespace FooBarQix
{
    public string Determine(int input)
    {

        string res = "";

        if (input % 3 == 0)
        {
            res += "Foo";
        }
        if (input % 5 == 0)
        {
            res += "Bar";
        }
        if (input % 7 == 0)
        {
            res += "Qix";
        }
        if (res == "")
        {
            res = input.ToString();
        }
        return res;
    }
}