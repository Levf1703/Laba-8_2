try
{
    Console.Write("Введите название товара: ");
    string tovar = Console.ReadLine();
    Console.Write("Введите дату оформления товара: ");
    string data = Console.ReadLine();
    Console.Write("Введите цену товара: ");
    double price = double.Parse(Console.ReadLine());
    Console.Write("Введите количество единиц товара: ");
    int count = int.Parse(Console.ReadLine());
    Console.Write("Введите номер накладной товара: ");
    string code = Console.ReadLine();
    Shop Lenta = new Goods(tovar, data, price, count, code);
    Lenta.CountGoodPrice();
    Lenta.Print();
    Lenta.ChangePrice();
    Lenta.ChangeAmount();
    Lenta.CountGoodPrice();
    Lenta.Print();
}
catch (Exception exp)
{
    Console.WriteLine(exp.Message);
}

interface Shop
{
    double ChangePrice();
    int ChangeAmount();
    double CountGoodPrice();
    void Print();
}

abstract class Stand : Shop
{
    protected double price;
    public virtual double ChangePrice()
    {
        Console.Write("Введите новую цену товара: ");
        price = double.Parse(Console.ReadLine());
        return price;
    }

    protected int amount;
    public virtual int ChangeAmount()
    {
        Console.Write("Введите новое количество товара: ");
        amount = int.Parse(Console.ReadLine());
        return amount;
    }

    protected double result;
    public virtual double CountGoodPrice()
    {
        result = price * amount;
        return result;
    }
    public abstract void Print();
}
class Goods : Stand
{
    public string name;
    public string data_day;
    public string document;
    public Goods(string name, string data_day, double price, int amount, string document)
    {
        this.name = name;
        this.data_day = data_day;
        this.price = price;
        this.amount = amount;
        this.document = document;
    }
    public override void Print()
    {
        Console.WriteLine("Название: {0}; Поступил: {1}; Цена: {2}; Количество: {3}; Накладная: {4}; Стоимость товара: {5}", name, data_day, price, amount, document, result);
    }
}
