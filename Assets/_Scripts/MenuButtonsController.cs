using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtonsController : MonoBehaviour
{
    public void PlayBtn()
    {
        SceneManager.LoadScene("Game");
    }

    public void ShopBtn()
    {

    }

}
