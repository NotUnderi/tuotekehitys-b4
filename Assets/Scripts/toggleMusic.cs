using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class toggleMusic : MonoBehaviour
{
    Toggle toggle;
    // Start is called before the first frame update
    void Start()
    {
        toggle = GetComponent<Toggle>();
        int musicStatus = PlayerPrefs.GetInt("MusicStatus");
        if (musicStatus == 1) { toggle.isOn = true; }
        else { toggle.isOn = false; }
        toggle.onValueChanged.AddListener(delegate
        {
            toggleSwitched();
        });
    }

    // Update is called once per frame
    void toggleSwitched()
    {
        int musicStatus = PlayerPrefs.GetInt("MusicStatus");
        int newStatus = (musicStatus == 1) ? 0 : 1;
        PlayerPrefs.SetInt("MusicStatus",newStatus);
        Debug.Log("Value changed");
    }

}
