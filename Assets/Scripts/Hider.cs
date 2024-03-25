using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hider : MonoBehaviour
{
    public GameObject credits;
    public GameObject mainmenu;
    private bool creditsOpen = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Credits()
    {
        if (creditsOpen == false)
        {
            credits.SetActive(true);
            mainmenu.SetActive(false);
            creditsOpen = true;
        }
        else if (creditsOpen == true)
        {

            credits.SetActive(false);
            mainmenu.SetActive(true);
            creditsOpen = false;

        }
    }
}
