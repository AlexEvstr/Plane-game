using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuButtonsController : MonoBehaviour
{
    [SerializeField] private GameObject _levelsPanel;
    [SerializeField] private GameObject _shopPanel;
    public void PlayBtn()
    {
        _levelsPanel.SetActive(true);
    }

    public void ShopBtn()
    {
        _shopPanel.SetActive(true);
    }

    public void CloseShopBtn()
    {
        _shopPanel.SetActive(false);
    }

}
