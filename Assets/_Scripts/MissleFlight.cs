using UnityEngine;

public class MissleFlight : MonoBehaviour
{
    [SerializeField] private GameObject _badExplosion;
    [SerializeField] private GameObject _goodExplosion;

    private float _speed = 10.0f;

    private CameraShake _cameraShake;

    private void Start()
    {
        _cameraShake = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<CameraShake>();
    }

    private void Update()
    {
        transform.Translate(Vector2.up * Time.deltaTime * _speed);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Construct"))
        {
            _cameraShake.Shake();
            GameObject badExplosion = Instantiate(_badExplosion);
            badExplosion.transform.position = transform.position;
            Destroy(badExplosion, 0.5f);
            Destroy(gameObject);
        }

        else if (collision.gameObject.CompareTag("Border"))
        {
            GameObject goodExplosion = Instantiate(_goodExplosion);
            goodExplosion.transform.position = transform.position;
            Destroy(goodExplosion, 0.5f);
            Destroy(gameObject);
            ScoreController.Score++;
            if (ScoreController.Score > ScoreController.BestScore)
            {
                ScoreController.BestScore = ScoreController.Score;
                PlayerPrefs.SetInt("BestScore", ScoreController.BestScore);
            }
        }
    }
}