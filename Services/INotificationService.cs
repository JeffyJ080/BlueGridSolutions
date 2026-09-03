namespace BlueGridSolutions.Services;

using BlueGridSolutions.Models;

public interface INotificationService
{
    event Action<ToastMessage>? OnShow;
    event Action<string>? OnHide;

    void Show(ToastMessage toast);
    void ShowSuccess(string message, string title = "Success");
    void ShowError(string message, string title = "Error");
    void ShowInfo(string message, string title = "Information");
    void ShowWarning(string message, string title = "Warning");
    void Hide(string id);
}
