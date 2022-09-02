using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sfx : MonoBehaviour
{
    public AudioSource Audio;
    public AudioClip Click;
    public bool musicToggle = true;
    public static Sfx sfxInstance;

    private void Awake()
    {
        if (sfxInstance != null && sfxInstance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        sfxInstance = this;
        //efektin/müziðin sahne geçiþlerinde durmamasýný,yok olmamasýný saðlar
        DontDestroyOnLoad(this);
    }
}
