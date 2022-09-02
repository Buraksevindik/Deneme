using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GetAudio : MonoBehaviour
{
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
}
