
// 正しい数量を扱うための独自クラス（Quantityクラス）を定義する
// 数量を１以上え100以下であるように制限したクラス
class Quantity
{
    static readonly int MIN = 1;
    static readonly int MAX = 100;

    int value;

    public Quantity(int value)
    {
        // 初期化時に数値をチェック
        if(value < MIN) throw new Exception($"不正な値です： {MIN} 未満");
        if(value > MAX) throw new Exception($"不正な値です： {MAX} 超");
        this.value = value;
    }

    public bool CanAdd(Quantity other)
    {
        int added = addValue(other);
        return added <= MAX;
    }

    Quantity add(Quantity other)
    {
        if (!CanAdd(other)) throw new Exception($"不正な値です： {MAX} 超");
        int added = addValue(other);
        return new Quantity(added);
    }

    private int addValue(Quantity other)
    {
        return this.value + other.value;
    }
}


class Program
{
    static void Main(string[] args)
    {
        //Quantity quantity = new Quantity(0); // System.Exception: '不正な値です： 1 未満'
        //Quantity quantity = new Quantity(101); // System.Exception: '不正な値です： 100 超'

        Quantity value_100 = new Quantity(100);
        Quantity value_20 = new Quantity(20);
        Quantity value_10 = new Quantity(10);

        Console.WriteLine(value_100.CanAdd(value_10));
        Console.WriteLine(value_20.CanAdd(value_10));

    }
}