using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayer : MonoBehaviour
{

    public AudioSource selectSound;
    public AudioSource music; 
    public bool musicOn = true;
    // Start is called before the first frame update
    void Start()
    {
        music.Play();
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void onSelect()
    {
        selectSound.Play();
    }

    public void switchMusic()
    {

        if (musicOn) { music.Pause(); musicOn = false; }
        else if (musicOn == false) { music.Play(); musicOn = true; }
    }
}
