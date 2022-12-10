namespace PhysicValuesLib.Values;

public class Vatt : IValue
{
    private double Value { get; set; }
    private string? From { get; set; }
    private string? To { get; set; }

    private string _valueName = "Ватт";

    private List<string> _measureList = new List<string>()
    {
        "Ват",
        "Кило Ватт",
        "Мега Ватт",
        "Мили Ватт"
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
            case "Ватт":
                break;
            case "Кило Ватт":
                Value /= 60;
                break;
            case "Мега Ватт":
                Value /= 3600;
                break;
            case "Мили Ватт":
                Value *= 1000;
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
            case "Ватт":
                break;
            case "Кило Ватт":
                Value *= 60;
                break;
            case "Мега Ватт":
                Value *= 3600;
                break;
            case "Мили Ватт":
                Value /= 1000;
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
