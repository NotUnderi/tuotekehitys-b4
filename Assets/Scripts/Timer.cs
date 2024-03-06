using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Timer : MonoBehaviour
{

    public float timeLeft = 15;
    public bool timerOn;
    public TextMeshProUGUI timer;
    public GameObject gameoverMenu;
    // Start is called before the first frame update
    void Start()
    {
        timerOn = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (timerOn)
        {
            if (timeLeft > 1)
            {
                timeLeft -= Time.deltaTime;
            }
            else
            {
                Gameover();
            }
        }

        

        string time_s = string.Format("{0}", Mathf.FloorToInt(timeLeft % 60));
        timer.text = time_s;

    }
    public void Gameover()
    {
        gameoverMenu.SetActive(true);
        Time.timeScale = 0.0f;
    }
}
