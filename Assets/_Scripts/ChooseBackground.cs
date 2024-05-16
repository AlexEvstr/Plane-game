using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChooseBackground : MonoBehaviour
{
    [SerializeField] private GameObject _tick;

    [SerializeField] private Image _background;
    [SerializeField] private Image _pauseBackground;
    [SerializeField] private Image _winBackground;
    [SerializeField] private Image _loseBackground;
    [SerializeField] private Sprite[] _backgrounds;

    private void Start()
    {
        int plane = PlayerPrefs.GetInt("Background", 0);
        if (plane == int.Parse(gameObject.name))
        {
            GetComponent<Image>().color = new Color(1f, 1f, 1f);
            _tick.transform.SetParent(transform);
        }
        else
        {
            GetComponent<Image>().color = new Color(0.75f, 0.75f, 0.75f);
        }

        int level = PlayerPrefs.GetInt("Level", 1);
        if (level >= int.Parse(transform.GetChild(1).name))
        {
            transform.GetChild(1).gameObject.SetActive(false);
            GetComponent<Button>().enabled = true;
        }
        else
        {
            GetComponent<Button>().enabled = false;
        }
    }

    public void PickBackground()
    {
        _tick.transform.SetParent(transform);
        PlayerPrefs.SetInt("Background", int.Parse(gameObject.name));
        int background = PlayerPrefs.GetInt("Background", 0);
        _background.sprite = _backgrounds[background];
        _pauseBackground.sprite = _backgrounds[background];
        _winBackground.sprite = _backgrounds[background];
        _loseBackground.sprite = _backgrounds[background];
    }

    private void Update()
    {
        if (transform.childCount == 3)
        {
            GetComponent<Image>().color = new Color(1, 1, 1);
        }
        else
        {
            GetComponent<Image>().color = new Color(0.75f, 0.75f, 0.75f);
            transform.GetChild(1).transform.GetComponent<Image>().color = new Color(0.75f, 0.75f, 0.75f);
        }
    }
}
