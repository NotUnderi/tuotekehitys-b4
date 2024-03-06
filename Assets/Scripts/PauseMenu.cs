using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    private bool isPaused;
    private float fixedDeltaTime;
    // Start is called before the first frame update
    void Start()
    {
        this.fixedDeltaTime = Time.fixedDeltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("escape") && isPaused==false){
            isPaused = true;
            Time.timeScale = 0.0f;
            Debug.Log("Escape pressed and game paused");
            
        }
        else if (Input.GetKeyDown("escape")&&isPaused==true){
            Time.timeScale = 1.0f;
            isPaused = false;
            Debug.Log("Escape presed and game unpaused");
        }
    }
}
