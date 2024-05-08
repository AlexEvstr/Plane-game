using UnityEngine;

public class MissleFlight : MonoBehaviour
{
    [SerializeField] private GameObject _badExplosion;
    [SerializeField] private GameObject _goodExplosion;

    private ButtonsController buttonsController;

    private float _speed = 10.0f;

    private CameraShake _cameraShake;
    private HeartsBehavior _heartsBehavior;

    private void Start()
    {
        buttonsController = GameObject.FindGameObjectWithTag("Controller").GetComponent<ButtonsController>();
        _cameraShake = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<CameraShake>();
        _heartsBehavior = GameObject.FindGameObjectWithTag("Controller").GetComponent<HeartsBehavior>();
    }

    private void Update()
    {
        transform.Translate(Vector2.up * Time.deltaTime * _speed);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Construct"))
        {
            buttonsController.PlayExplosionSound();
            _cameraShake.Shake();
            GameObject badExplosion = Instantiate(_badExplosion);
            badExplosion.transform.position = transform.position;
            Destroy(badExplosion, 0.5f);
            Destroy(gameObject);
            _heartsBehavior.LoveHeart();
        }

        else if (collision.gameObject.CompareTag("Border"))
        {
            buttonsController.PlayGoodShotSound();
            GameObject goodExplosion = Instantiate(_goodExplosion);
            goodExplosion.transform.position = transform.position;
            Destroy(goodExplosion, 0.5f);
            Destroy(gameObject);
            ScoreController.Score++;

            //if (ScoreController.Score > ScoreController.BestScore)
            //{
            //    ScoreController.BestScore = ScoreController.Score;
            //    PlayerPrefs.SetInt("BestScore", ScoreController.BestScore);
            //}
        }
    }
}