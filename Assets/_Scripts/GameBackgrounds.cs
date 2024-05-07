using UnityEngine;
using UnityEngine.UI;

public class GameBackgrounds : MonoBehaviour
{
    [SerializeField] private Image _background;
    [SerializeField] private Sprite[] _backgrounds;

    private void Start()
    {
        int background = PlayerPrefs.GetInt("Background", 0);
        _background.sprite = _backgrounds[background];
    }
}