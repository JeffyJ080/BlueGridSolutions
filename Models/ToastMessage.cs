namespace BlueGridSolutions.Models;

public enum ToastType
{
    Success,
    Error,
    Info,
    Warning
}

public class ToastMessage
{
    public string Id { get; set; } = Guid.NewGuid().ToString("N");
    public string Title { get; set; } = string.Empty;
    public string Message { get; set; } = string.Empty;
    public ToastType Type { get; set; } = ToastType.Info;
    public int DurationMs { get; set; } = 4500;
    public DateTime Timestamp { get; set; } = DateTime.UtcNow;
}
