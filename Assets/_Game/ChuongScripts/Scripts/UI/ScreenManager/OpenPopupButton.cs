using ChuongCustom;
using UnityEngine;
using UnityEngine.UI;

public class OpenPopupButton : MonoBehaviour
{
    private Button _buttonClick;

    [SerializeField] private ScreenType _screenType;

    void Start()
    {
        _buttonClick = GetComponent<Button>();
        _buttonClick.onClick.AddListener(OnClickButton);
    }

    private void OnClickButton()
    {
        MasterAudioManager.ClickSound();
        if (_screenType == ScreenType.Back)
        {
            ScreenManager.Instance.Back();
        }
        else
        {
            ScreenManager.Instance.OpenScreen(_screenType);
        }
    }
}