using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonsController : MonoBehaviour
{
    [SerializeField] private GameObject _pausePanel;
    public static bool canVibration;

    private AudioSource _audioSource;
    [SerializeField] private AudioClip _clickSound;
    [SerializeField] private AudioClip _explosionSound;
    [SerializeField] private AudioClip _goodShotSound;
    [SerializeField] private AudioClip _loseSound;
    [SerializeField] private AudioClip _shotSoundd;
    [SerializeField] private AudioClip _winSound;

    private void Start()
    {
        Time.timeScale = 1;
        Screen.orientation = ScreenOrientation.Portrait;
        Vibration.Init();

        _audioSource = GetComponent<AudioSource>();

        int vibro = PlayerPrefs.GetInt("vibration", 1);
        if (vibro == 0)
        {
            canVibration = false;
        }
        else
        {
            canVibration = true;
        }
    }

    public void RestartBtn()
    {
        SceneManager.LoadScene("Game");
    }

    public void MenuBtn()
    {
        SceneManager.LoadScene("Menu");
    }

    public void PauseBtn()
    {
        _pausePanel.SetActive(true);
        Time.timeScale = 0;
    }

    public void ClosePause()
    {
        _pausePanel.SetActive(false);
        Time.timeScale = 1;
    }

    public void PlayClickSound()
    {
        if (canVibration) Vibration.VibratePop();
        _audioSource.PlayOneShot(_clickSound);
    }
    public void PlayExplosionSound()
    {
        if (canVibration) Vibration.VibrateNope();
        _audioSource.PlayOneShot(_explosionSound);
    }
    public void PlayGoodShotSound()
    {
        if (canVibration) Vibration.VibratePeek();
        _audioSource.PlayOneShot(_goodShotSound);
    }
    public void PlayLooseSound()
    {
        _audioSource.PlayOneShot(_loseSound);
    }
    public void PlayShootSound()
    {
        if (canVibration) Vibration.VibratePop();
        _audioSource.PlayOneShot(_shotSoundd);
    }
    public void PlayWinSound()
    {
        _audioSource.PlayOneShot(_winSound);
    }
}