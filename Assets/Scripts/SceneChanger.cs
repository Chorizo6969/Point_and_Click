using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public GameObject scene;

    public void ChangeScene()
    {
        SceneManager.LoadScene("basementScene");

    }
}
