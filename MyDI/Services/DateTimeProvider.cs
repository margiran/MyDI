namespace MyDI.Services;

public class DateTimeProvider
{
    public DateTimeOffset DateTime { get; set; } = DateTimeOffset.UtcNow;

    public string Get()
    {
        return DateTime.ToUnixTimeMilliseconds().ToString();
    }
}
