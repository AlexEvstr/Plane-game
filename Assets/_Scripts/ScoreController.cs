using UnityEngine;
using TMPro;
using System.Collections;

public class ScoreController : MonoBehaviour
{
    [SerializeField] private TMP_Text _scoreText;
    [SerializeField] private TMP_Text _bestScoreText;

    [SerializeField] private GameObject winLevel;

    private bool _finished = false;

    public static int Score;
    public static int BestScore;

    private void Start()
    {
        //BestScore = PlayerPrefs.GetInt("BestScore", 0);
        Score = 0;
    }

    private void Update()
    {
        _scoreText.text = $"{Score}/30";
        if (Score == 30 && !_finished)
        {
            StartCoroutine(ShowWin());
            _finished = true;
        }
        //_bestScoreText.text = $"Best: {BestScore}";
    }

    private IEnumerator ShowWin()
    {
        yield return new WaitForSeconds(0.5f);
        winLevel.SetActive(true);
        LevelController.Level++;
        PlayerPrefs.SetInt("Level", LevelController.Level);
        int bestLevel = PlayerPrefs.GetInt("BestLevel", 1);
        if (LevelController.Level > bestLevel)
        {
            bestLevel = LevelController.Level;
            PlayerPrefs.SetInt("BestLevel", bestLevel);
        }

    }
}