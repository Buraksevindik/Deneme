using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    [SerializeField] private Sprite musicSound_On;
    [SerializeField] private Sprite musicSound_Off;
    [SerializeField] private Button musicButton;
    [SerializeField] private Sprite sfxSound_On;
    [SerializeField] private Sprite sfxSound_Off;
    [SerializeField] private Button sfxButton;
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (Sfx.sfxInstance.musicToggle == true)
            {
                Sfx.sfxInstance.Audio.PlayOneShot(Sfx.sfxInstance.Click);
            }
        }
    }
    private void Start()
    {
        LoadBG();
        LoadSFX();
    }
    private void SaveBG()
    {
        PlayerPrefs.SetFloat("audioVolume", BgMusic.BgInstance.Audio.volume);
    }
    public void LoadBG() 
    {
        BgMusic.BgInstance.Audio.volume = PlayerPrefs.GetFloat("audioVolume");
        if (BgMusic.BgInstance.Audio.volume == 0 && musicButton)
        {
            musicButton.GetComponent<Image>().sprite = musicSound_Off;
        }
        else if (BgMusic.BgInstance.Audio.volume != 0 && musicButton)
        {
            musicButton.GetComponent<Image>().sprite = musicSound_On;
        }
    }
    private void SaveSFX()
    {
        PlayerPrefs.SetInt("sfxVolume", Sfx.sfxInstance.musicToggle ? 1 : 0);
    }
    public void LoadSFX()
    {
        Sfx.sfxInstance.musicToggle = PlayerPrefs.GetInt("sfxVolume") == 1;
        if (Sfx.sfxInstance.musicToggle&& sfxButton)
        {
            sfxButton.GetComponent<Image>().sprite = sfxSound_On;
        }
        else if(!Sfx.sfxInstance.musicToggle && sfxButton)
        {
            sfxButton.GetComponent<Image>().sprite = sfxSound_Off;
        }
    }
    public void SfxToggle()
    {
        if (Sfx.sfxInstance.musicToggle)
        {
            Sfx.sfxInstance.musicToggle = false;
            sfxButton.GetComponent<Image>().sprite = sfxSound_Off;
            SaveSFX();
        }
        else
        {
            Sfx.sfxInstance.musicToggle = true;
            sfxButton.GetComponent<Image>().sprite = sfxSound_On;
            SaveSFX();
        }

    }
    public void MusicToggle()
    {
        if (BgMusic.BgInstance.Audio.volume == 0)
        {
            musicButton.GetComponent<Image>().sprite = musicSound_On;
            BgMusic.BgInstance.Audio.volume = 100;
            SaveBG();
        }
        else
        {
            musicButton.GetComponent<Image>().sprite = musicSound_Off;
            BgMusic.BgInstance.Audio.volume = 0;
            SaveBG(); 
        }
    }
}
