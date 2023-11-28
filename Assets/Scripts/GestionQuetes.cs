using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GestionQuetes : MonoBehaviour
{
    public TMP_Text Quete;

    private void Start()
    {
        ValiderQuete();
    }
    public void ValiderQuete()
    {
        Quete.text = "ntm";
    }
}
