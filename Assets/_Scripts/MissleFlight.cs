using UnityEngine;

public class MissleFlight : MonoBehaviour
{
    private float _speed = 5.0f;

    private void Update()
    {
        transform.Translate(Vector2.up * Time.deltaTime * _speed);
    }
}
