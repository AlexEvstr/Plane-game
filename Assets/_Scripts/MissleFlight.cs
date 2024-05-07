using UnityEngine;

public class MissleFlight : MonoBehaviour
{
    [SerializeField] private GameObject _badExplosion;

    private float _speed = 10.0f;

    private void Update()
    {
        transform.Translate(Vector2.up * Time.deltaTime * _speed);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Construct"))
        {
            GameObject badExplosion = Instantiate(_badExplosion);
            badExplosion.transform.position = transform.position;
            Destroy(badExplosion, 0.5f);
            Destroy(gameObject);
        }
    }
}
