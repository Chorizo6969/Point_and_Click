using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class ChancesRestantes : MonoBehaviour
{
    public TMP_Text TextNbChances;
    private string TextOriginal;
    public int NbChances = 3;
    
    private void Start()
    {
        TextOriginal = TextNbChances.text;
        TextNbChances.text = TextOriginal + " " + NbChances.ToString();
    }

    public void ChangeScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }

    public void ReduireNbChances()
    {
        NbChances -= 1;
        TextNbChances.text = TextOriginal + " " + NbChances.ToString();
        if (NbChances == 0)
        {
            ChangeScene("GameOver");
        }
    }
    
}
