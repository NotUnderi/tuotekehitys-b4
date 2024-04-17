using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public bool isPaused;
    public GameObject pausemenuCanvas;
    public GameObject submenu;
    private AudioSource music;
    private bool submenuOpen = false;
    //private float fixedDeltaTime;
    // Start is called before the first frame update
    void Start()
    {
        isPaused = false;
        Time.timeScale = 1.0f;
        music = GetComponent<AudioSource>();
        //this.fixedDeltaTime = Time.fixedDeltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("escape") )
        {
            if (isPaused) { Resume(); }
            else { Pause(); }
        }

    }
    public void Resume()
    {
        Time.timeScale = 1.0f;
        pausemenuCanvas.SetActive(false);
        isPaused = false;
        if (PlayerPrefs.GetInt("MusicStatus")==1) { music.Play(); }
        Debug.Log("Escape presed and game unpaused");
    }

    void Pause()
    {
        isPaused = true;
        pausemenuCanvas.SetActive(true);
        Time.timeScale = 0.0f;
        Debug.Log("Escape pressed and game paused");
        music.Pause();
    }
    public void Submenu()
    {
        Debug.Log("Submenu function called");
        if (submenuOpen == false)
        {
            submenuOpen = true;
            submenu.SetActive(true);
            Debug.Log("Submenu opened");
        }
        else if (submenuOpen == true)
        {
            submenuOpen = false;
            submenu.SetActive(false);
            Debug.Log("Submenu closed");

        }
    }
}
