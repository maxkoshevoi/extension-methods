/// <summary>
/// Makes it easy to get value from DataRow`s cell in needed type.
/// Uses TypeConverter from this repository.
/// </summary>
public static class DataRowEx
{
    public static T Get<T>(this DataRow row, int columnIndex, bool DefaultIfNull = false)
    {
        return TypeConverter.Get<T>(row[columnIndex], DefaultIfNull);
    }

    public static T Get<T>(this DataRow row, string columnName, bool DefaultIfNull = false)
    {
        return TypeConverter.Get<T>(row[columnName], DefaultIfNull);
    }

    public static bool IsNull(this DataRow row, int index)
    {
        return TypeConverter.IsNull(row[index]);
    }
}
