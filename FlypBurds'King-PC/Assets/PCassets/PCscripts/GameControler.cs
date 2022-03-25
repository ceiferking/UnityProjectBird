using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControler : MonoBehaviour
{

    public void ResetGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("SampleScenePC");
    }
}
