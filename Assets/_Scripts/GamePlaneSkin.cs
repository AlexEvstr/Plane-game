using UnityEngine;

public class GamePlaneSkin : MonoBehaviour
{
    [SerializeField] private SpriteRenderer _plane;
    [SerializeField] private Sprite[] _planes;

    private void Start()
    {
        int planeIndex = PlayerPrefs.GetInt("Plane", 0);
        _plane.sprite = _planes[planeIndex];
    }
}