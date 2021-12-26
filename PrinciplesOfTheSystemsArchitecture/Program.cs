
// 正しい数量を扱うための独自クラス（Quantityクラス）を定義する
class Quantity
{
    static readonly int MIN = 1;
    static readonly int MAX = 100;

    int value;

    Quantity(int value)
    {
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


