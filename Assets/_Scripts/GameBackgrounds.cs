using UnityEngine;
using UnityEngine.UI;

public class GameBackgrounds : MonoBehaviour
{
    [SerializeField] private Image _background;
    [SerializeField] private Image _pauseBackground;
    [SerializeField] private Image _winBackground;
    [SerializeField] private Image _loseBackground;
    [SerializeField] private Sprite[] _backgrounds;

    private void Start()
    {
        int background = PlayerPrefs.GetInt("Background", 0);
        _background.sprite = _backgrounds[background];
        _pauseBackground.sprite = _backgrounds[background];
        _winBackground.sprite = _backgrounds[background];
        _loseBackground.sprite = _backgrounds[background];
    }
}