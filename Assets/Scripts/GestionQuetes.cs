using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GestionQuetes : MonoBehaviour
{
    public TMP_Text Quete;
    public int TemoinsInterroges = 1;
    public void ValiderQuete()
    {
        Quete.text = "ntm";
    }

    public void InterrogerTemoin()
    {
        Quete.text = "Interrogez les témoins (" + TemoinsInterroges + "/3)";
        TemoinsInterroges += 1;
    }
}
