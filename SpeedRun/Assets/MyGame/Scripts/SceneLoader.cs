using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public void LoadScene2()
    {
        SceneManager.LoadScene("Scene2");
    }
    public void LoadScene3()
    {
        SceneManager.LoadScene("Scene3");
    }
}
