class Car
{
    public string color = "red";
    public int year = 1992;

    public Car(string colorArg, int yearArg)
    {
        color = colorArg;
        year = yearArg;
    }

    public int AddTwo(int num1, int num2)
    {
        return num1 + num2;
    }
}