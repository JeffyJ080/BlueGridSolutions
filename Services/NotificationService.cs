namespace BlueGridSolutions.Services;

using BlueGridSolutions.Models;

public class NotificationService : INotificationService
{
    public event Action<ToastMessage>? OnShow;
    public event Action<string>? OnHide;

    public void Show(ToastMessage toast)
    {
        OnShow?.Invoke(toast);
    }

    public void ShowSuccess(string message, string title = "Success")
    {
        Show(new ToastMessage
        {
            Title = title,
            Message = message,
            Type = ToastType.Success
        });
    }

    public void ShowError(string message, string title = "Error")
    {
        Show(new ToastMessage
        {
            Title = title,
            Message = message,
            Type = ToastType.Error
        });
    }

    public void ShowInfo(string message, string title = "Information")
    {
        Show(new ToastMessage
        {
            Title = title,
            Message = message,
            Type = ToastType.Info
        });
    }

    public void ShowWarning(string message, string title = "Warning")
    {
        Show(new ToastMessage
        {
            Title = title,
            Message = message,
            Type = ToastType.Warning
        });
    }

    public void Hide(string id)
    {
        OnHide?.Invoke(id);
    }
}
