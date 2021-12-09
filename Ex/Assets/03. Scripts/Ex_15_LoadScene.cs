using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ex_15_LoadScene : MonoBehaviour {

    public static int sceneLoadNumber = 0;
    public static bool stage_2 = false;

    public string sceneName;

    void Update()
    {
        if (sceneLoadNumber == 3 && stage_2 == false)
        {
            sceneLoadNumber = 0;
            stage_2 = true;
            SceneManager.LoadScene(sceneName);
        }
        else if (sceneLoadNumber == 5 && stage_2 == true)
        {
            sceneLoadNumber = 0;
            stage_2 = false;
            SceneManager.LoadScene(sceneName);
        }
    }
}
