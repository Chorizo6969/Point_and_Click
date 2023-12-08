using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{

    public void ChangeScene()
    {
        SceneManager.LoadScene("basementScene");

    }
    public void ChangeScene_GoodEnding()
    {
        SceneManager.LoadScene("GOOD ENDING");

    }
    public void ChangeScene_GameOver()
    {
        SceneManager.LoadScene("Game Over");
    }

    public void ChangeScene_Menu()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
