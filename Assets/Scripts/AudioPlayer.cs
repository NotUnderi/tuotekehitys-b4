using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AudioPlayer : MonoBehaviour
{

    public AudioSource music;
    private AudioSource selectSound;
    private int musicStatus;
    // Start is called before the first frame update
    void Start()
    {
        selectSound = GetComponent<AudioSource>();
        musicStatus = PlayerPrefs.GetInt("MusicStatus",1);
        if (musicStatus == 1) { music.Play(); }
        else
        {

        }
    }

    // Update is called once per frame
    void Update()
    {
        musicStatus = PlayerPrefs.GetInt("MusicStatus");
        if (musicStatus == 0) { music.Pause(); }
        else if (musicStatus == 1 && !music.isPlaying) { music.Play(); }
    }

    public void onSelect()
    {
        selectSound.Play();
    }

}
