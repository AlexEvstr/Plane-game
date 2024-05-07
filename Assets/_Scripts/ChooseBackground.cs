using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChooseBackground : MonoBehaviour
{
    [SerializeField] private GameObject _tick;

    private void Start()
    {
        int plane = PlayerPrefs.GetInt("Background", 0);
        if (plane == int.Parse(gameObject.name))
        {
            GetComponent<Image>().color = new Color(0.5f, 0.5f, 0.5f);
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
    }

    private void Update()
    {
        if (transform.childCount == 3)
        {
            GetComponent<Image>().color = new Color(0.5f, 0.5f, 0.5f);
        }
        else
        {
            GetComponent<Image>().color = new Color(0.75f, 0.75f, 0.75f);
        }
    }
}
