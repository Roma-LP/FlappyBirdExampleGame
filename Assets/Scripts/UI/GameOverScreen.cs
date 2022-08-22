using UnityEngine;
using UnityEngine.Events;

public class GameOverScreen : Screen
{
    public event UnityAction RestartButttonClick;
    public override void Close()
    {
        ScreenObject.SetActive(false);
        // CanvasGroup.alpha = 0;
        //Button.interactable = false;
        Button.gameObject.SetActive(false);
    }

    public override void Open()
    {
        ScreenObject.SetActive(true);
        // CanvasGroup.alpha = 1;
        // Button.interactable = true;
        Button.gameObject.SetActive(true);
    }

    protected override void OnButtonClick()
    {
        RestartButttonClick?.Invoke();
    }
}