using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelPicker : MonoBehaviour
{
    private void Start()
    {
        int bestLevel = PlayerPrefs.GetInt("BestLevel", 1);
        if (bestLevel < int.Parse(gameObject.name))
        {
            GetComponent<Button>().enabled = false;
            GetComponent<Image>().color = new Color(0.5f, 0.5f, 0.5f);
        }
        else
        {
            GetComponent<Button>().enabled = true;
            GetComponent<Image>().color = new Color(0.9f,0.9f,0.9f);
        }
    }

    public void PickThisLevel()
    {
        PlayerPrefs.SetInt("Level", int.Parse(gameObject.name));
        SceneManager.LoadScene("Game");
    }
}
