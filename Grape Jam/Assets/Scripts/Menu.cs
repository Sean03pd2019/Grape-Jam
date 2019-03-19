using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    // Update is called once per frame
    void TaskOnClick()
    {
        SceneManager.LoadScene("World1");
    }
}
