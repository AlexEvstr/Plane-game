using UnityEngine;
using TMPro;

public class ScoreController : MonoBehaviour
{
    [SerializeField] private TMP_Text _scoreText;
    [SerializeField] private TMP_Text _bestScoreText;

    public static int Score;
    public static int BestScore;

    private void Start()
    {
        BestScore = PlayerPrefs.GetInt("BestScore", 0);
        Score = 0;
    }

    private void Update()
    {
        _scoreText.text = Score.ToString();
        _bestScoreText.text = $"Best: {BestScore}";
    }
}