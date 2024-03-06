using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadScene : MonoBehaviour
{
    void Start()
    {
        
    }

    public void quit() {Application.Quit();}
    public void loadScene(string sceneName){
        SceneManager.LoadScene(sceneName,LoadSceneMode.Single);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}