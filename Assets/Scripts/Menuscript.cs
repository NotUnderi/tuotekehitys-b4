using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadScene : MonoBehaviour
{
    public Button button1,button2,button3;
    void Start()
    {
        button1.onClick.AddListener(delegate{loadScene(1);});
        button2.onClick.AddListener(quit);
        button3.onClick.AddListener(delegate{loadScene(2);});
    }

    void quit() {Application.Quit();}
    void loadScene(int sceneIndex){
        SceneManager.LoadScene(sceneIndex,LoadSceneMode.Single);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}