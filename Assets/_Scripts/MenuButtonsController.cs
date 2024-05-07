using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuButtonsController : MonoBehaviour
{
    [SerializeField] private GameObject _levelsPanel;
    public void PlayBtn()
    {
        _levelsPanel.SetActive(true);
    }

    public void ShopBtn()
    {

    }

}
