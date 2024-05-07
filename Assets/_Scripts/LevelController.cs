using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LevelController : MonoBehaviour
{
    [SerializeField] private TMP_Text _levelText;

    public static int Level;

    private void Start()
    {
        Level = PlayerPrefs.GetInt("Level", 1);
        _levelText.text = $"Level: {Level}";
    }
}
