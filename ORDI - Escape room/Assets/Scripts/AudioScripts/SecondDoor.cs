using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondDoor : MonoBehaviour
{
    private GameObject LowPolyTheme;
    private AudioSource lPThemeAudioSource;

    private GameObject serverTheme;
    private AudioSource sThemeAudioSource;

    private bool roomLocation = true;
    // Start is called before the first frame update
    void Start()
    {
        LowPolyTheme = GameObject.Find("LowPolyTheme");
        lPThemeAudioSource = LowPolyTheme.GetComponent<AudioSource>();

        serverTheme = GameObject.Find("ServerTheme");
        sThemeAudioSource = serverTheme.GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (roomLocation)
        {
            lPThemeAudioSource.Pause();
            sThemeAudioSource.Play();
            roomLocation = false;
        }
        else
        {
            sThemeAudioSource.Pause();
            lPThemeAudioSource.Play();
            roomLocation = true;
        }

    }
}
