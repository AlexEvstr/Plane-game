using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartsBehavior : MonoBehaviour
{
    [SerializeField] private GameObject[] _heartsBroken;
    [SerializeField] private GameObject[] _heartsGrey;

    public void LoveHeart()
    {
        StartCoroutine(LoseOneHeart());
    }

    private IEnumerator LoseOneHeart()
    {
        if (!_heartsGrey[2].activeInHierarchy)
        {
            _heartsBroken[2].SetActive(true);
            yield return new WaitForSeconds(0.5f);
            _heartsGrey[2].SetActive(true);
        }
        else if (!_heartsGrey[1].activeInHierarchy)
        {
            _heartsBroken[1].SetActive(true);
            yield return new WaitForSeconds(0.5f);
            _heartsGrey[1].SetActive(true);
        }
        else if (!_heartsGrey[0].activeInHierarchy)
        {
            _heartsBroken[0].SetActive(true);
            yield return new WaitForSeconds(0.5f);
            _heartsGrey[0].SetActive(true);
        }
    }
}
