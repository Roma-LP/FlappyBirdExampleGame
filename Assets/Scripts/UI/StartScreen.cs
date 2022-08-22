using UnityEngine;
using UnityEngine.Events;

public class StartScreen : Screen
{
    public event UnityAction PlayButttonClick;
    public override void Close()
    {
        ScreenObject.SetActive(false);
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
        PlayButttonClick?.Invoke();
    }
}