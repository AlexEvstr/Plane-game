using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuButtonsController : MonoBehaviour
{
    [SerializeField] private GameObject _levelsPanel;
    [SerializeField] private GameObject _shopPanel;
    [SerializeField] private GameObject _tutorial;

    private AudioSource _audioSource;
    [SerializeField] private AudioClip _click;

    [SerializeField] private GameObject _soundOn;
    [SerializeField] private GameObject _soundOff;

    [SerializeField] private GameObject _vibroOn;
    [SerializeField] private GameObject _vibroOff;

    public static bool Vibration;

    private void Start()
    {
        Time.timeScale = 1;
        _audioSource = GetComponent<AudioSource>();

        int vibro = PlayerPrefs.GetInt("vibration", 1);
        if (vibro == 0)
        {
            _vibroOn.SetActive(false);
            _vibroOff.SetActive(true);
            Vibration = false;
        }
        else
        {
            _vibroOff.SetActive(false);
            _vibroOn.SetActive(true);
            Vibration = true;
        }

        float volume = PlayerPrefs.GetInt("audio", 1);
        if (volume == 0)
        {
            _soundOn.SetActive(false);
            _soundOff.SetActive(true);
            AudioListener.volume = 0;
        }
        else
        {
            _soundOff.SetActive(false);
            _soundOn.SetActive(true);
            AudioListener.volume = 1;
        }
    }

    public void PlayBtn()
    {
        _audioSource.PlayOneShot(_click);
        _levelsPanel.SetActive(true);
    }

    public void ShopBtn()
    {
        _audioSource.PlayOneShot(_click);
        _shopPanel.SetActive(true);
    }

    public void CloseShopBtn()
    {
        _audioSource.PlayOneShot(_click);
        _shopPanel.SetActive(false);
    }

    public void TutorialBtn()
    {
        _audioSource.PlayOneShot(_click);
        _tutorial.SetActive(true);
    }

    public void CloseTutorial()
    {
        _audioSource.PlayOneShot(_click);
        _tutorial.SetActive(false);
    }

    public void SoudOffBtn()
    {
        _audioSource.PlayOneShot(_click);
        _soundOn.SetActive(false);
        _soundOff.SetActive(true);
        AudioListener.volume = 0;
        PlayerPrefs.SetFloat("audio", AudioListener.volume);
    }

    public void SoudOnBtn()
    {
        _audioSource.PlayOneShot(_click);
        _soundOff.SetActive(false);
        _soundOn.SetActive(true);
        AudioListener.volume = 1;
        PlayerPrefs.SetFloat("audio", AudioListener.volume);
    }

    public void VibroOffBtn()
    {
        _audioSource.PlayOneShot(_click);
        _vibroOn.SetActive(false);
        _vibroOff.SetActive(true);
        Vibration = false;
        PlayerPrefs.SetInt("vibration", 0);
    }

    public void VibroOnBtn()
    {
        _audioSource.PlayOneShot(_click);
        _vibroOff.SetActive(false);
        _vibroOn.SetActive(true);
        Vibration = true;
        PlayerPrefs.SetInt("vibration", 1);
    }

    public void PlayClickSound()
    {
        _audioSource.PlayOneShot(_click);
    }
}