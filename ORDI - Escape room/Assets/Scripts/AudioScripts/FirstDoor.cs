using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstDoor : MonoBehaviour
{
    public GameObject MedievalTheme;
    public AudioSource mThemeAudioSource;
    private GameObject LowPolyTheme;
    private AudioSource lPThemeAudioSource;

    private bool roomLocation = true;

    bool firstPassageThrough = false;
    // Start is called before the first frame update
    void Start()
    {
        MedievalTheme = GameObject.Find("MedievalTheme");
        mThemeAudioSource = MedievalTheme.GetComponent<AudioSource>();
        LowPolyTheme = GameObject.Find("LowPolyTheme");
        lPThemeAudioSource = LowPolyTheme.GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (roomLocation)
        {
            mThemeAudioSource.Pause();
            lPThemeAudioSource.Play();
            roomLocation = false;
            if (!firstPassageThrough) {
                GameObject.Find("SoundManager").GetComponent<AudioSource>().Stop();
                SoundManagerScript.PlaySound("lowPoly2");
                firstPassageThrough = true;
            }
        }
        else {
            lPThemeAudioSource.Pause();
            mThemeAudioSource.Play();
            roomLocation = true;
        }

    }
}
