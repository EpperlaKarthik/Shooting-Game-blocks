using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//using UnityEngine.UI;

public class Scenemanager : MonoBehaviour
{
   public float time = 20.0f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;
       
        if(time<=0)
        {
            LoadNextScene();
        }
    }
    public void LoadNextScene()
    {
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentScene + 1);
    }
    public void LoadPreviousScene()
    {
        int currentScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentScene - 1);

    }
    public void QuitScene()
    {

        Application.Quit();

    }
}

        