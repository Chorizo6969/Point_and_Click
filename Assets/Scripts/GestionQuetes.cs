using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GestionQuetes : MonoBehaviour
{
    public TMP_Text Quete;
    public int TemoinsInterroges = 0;
    public int NBtemoins = 3;
    public void ValiderQuete()
    {
        Quete.text = "ntm";
    }

    public void InterrogerTemoin()
    {
        TemoinsInterroges += 1;
        Quete.text = "Interrogez les témoins (" + TemoinsInterroges + "/" + NBtemoins + ")";
        if (TemoinsInterroges == NBtemoins)
        {
            ValiderQuete();
        }
    }
}
