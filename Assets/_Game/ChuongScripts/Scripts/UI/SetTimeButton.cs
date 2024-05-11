using ChuongCustom;
using TMPro;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

public class SetTimeButton : MonoBehaviour
{
    [FormerlySerializedAs("_button")] [SerializeField] private Button button;
    [SerializeField] private TextMeshProUGUI _text;

    private float _time;

    private void OnValidate()
    {
        _text = GetComponentInChildren<TextMeshProUGUI>();
    }

    private void Start()
    {
        button?.onClick.AddListener(OnClickButton);
    }

    private void OnClickButton()
    {
        MasterAudioManager.ClickSound();
        ScreenManager.Instance.Back();
    }

    public void SetTime(int i)
    {
        switch (i)
        {
            case 0:
                _time = 60;
                _text.SetText("1 Phút");
                break;
            case 1:
                _time = 60 * 10;
                _text.SetText("10 Phút");
                break;
            case 2:
                _time = 60 * 30;
                _text.SetText("30 Phút");
                break;
            case 3:
                _time = 60 * 60;
                _text.SetText("1 Tiếng");
                break;
            case 4:
                _time = 60 * 60 * 2;
                _text.SetText("2 Tiếng");
                break;
            case 5:
                _time = 60 * 60 * 3;
                _text.SetText("3 Tiếng");
                break;
        }
    }
}