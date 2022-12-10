namespace PhysicValuesLib.Values;

public class Speed : IValue
{
    private double Value { get; set; }
    private string? From { get; set; }
    private string? To { get; set; }

    private string _valueName = "Скорость";

    private List<string> _measureList = new List<string>()
    {
        "Метр/c",
        "Километр/c",
        "Узел",
        "Скорость света"
        
    };

    /// <summary>
    /// Метод возвращает конвертированное значение
    /// </summary>
    /// <returns></returns>
    public double GetConvertedValue(double value, string from, string to)
    {
        Value = value;
        From = from;
        To = to;

        ToSi();
        ToRequired();
        return Value;
    }

    /// <summary>
    /// Метод возвращает список единиц измерения
    /// </summary>
    /// <returns></returns>
    public List<string> GetMeasureList()
    {
        return _measureList;
    }

    /// <summary>
    /// Метод конвертирует в нужные единицы измерения
    /// </summary>
    public void ToRequired()
    {
        switch (To)
        {
            case "Метр/c":
                break;
            case "Километр/ч":
                Value /= 3.6;
                break;
            case "Узел":
                Value /= 1.94384449244;
                break;
            case "Скорость света":
                Value *= 0.00000000333564095198;
                break;
            

        }
    }

    /// <summary>
    /// Метод переводит в систему СИ
    /// </summary>
    public void ToSi()
    {
        switch (From)
        {
            case "Метр/c":
                break;
            case "Километр/ч":
                Value *= 3.6;
                break;
            case "Узел":
                Value *= 1.94384449244;
                break;
            case "Скрость света":
                Value *= 0.00000000333564095198;
                break;
            

        }
    }

    public string GetValueName()
    {
        return _valueName;
    }

    public Dictionary<string, double> ConvertationCoefficient()
    {
        throw new NotImplementedException();
    }
}

