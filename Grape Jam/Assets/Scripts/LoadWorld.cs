using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadWorld : MonoBehaviour
{

    public string sceneName;

    // Start is called before the first frame update
    void Start()
    {
        if (sceneName != null)
        {
            SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
        }
        else
        {
            SceneManager.LoadScene("TitleScreen", LoadSceneMode.Single);
        }
    }

}
