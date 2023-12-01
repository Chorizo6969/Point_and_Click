using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class ChancesRestantes : MonoBehaviour
{
    public TMP_Text TextNbChances;
    private string TextOriginal;
    public int NbChances = 3;
    public GameObject ActiverObjet;
    public GameObject DesactiverObjet;
    
    private void Start()
    {
        TextOriginal = TextNbChances.text;
        TextNbChances.text = TextOriginal + " " + NbChances.ToString();
    }



    public void ReduireNbChances()
    {
        NbChances -= 1;
        TextNbChances.text = TextOriginal + " " + NbChances.ToString();
        if (NbChances == 0)
        {
            ActiverObjet.SetActive(true);
            DesactiverObjet.SetActive(false);
        }
    }
    
}
