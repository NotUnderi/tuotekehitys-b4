using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadScene : MonoBehaviour
{
    public Button startButton,exitButton,creditsButton;
    void Start()
    {
        startButton.onClick.AddListener(delegate{loadScene(1);});
        exitButton.onClick.AddListener(quit);
        creditsButton.onClick.AddListener(delegate{loadScene(2);});
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