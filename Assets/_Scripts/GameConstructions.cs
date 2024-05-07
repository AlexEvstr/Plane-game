using UnityEngine;

public class GameConstructions : MonoBehaviour
{
    [SerializeField] private GameObject[] _constructions;

    private void OnEnable()
    {
        int constructionIndex = PlayerPrefs.GetInt("Construction", 0);
        _constructions[constructionIndex].SetActive(true);
    }
}