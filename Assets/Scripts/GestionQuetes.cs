using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GestionQuetes : MonoBehaviour
{
    public TMP_Text Quete;
    private string original;
    public bool isDone = false;
    public int TemoinsInterroges = 0;
    public int NbTemoins;
    public bool IsCompteur;

    private void Start()
    {
        original = Quete.text;
        if (IsCompteur)
        {
        Quete.text = original + "(0/" + NbTemoins + ")";

        }
    }
    public void ValiderQuete() //raye le texte de la qu�te si celle-ci est valid�e et set "isValid" a true
    {
        Quete.fontStyle = FontStyles.Strikethrough;
        isDone = true;
        if (transform.parent.gameObject.GetComponent<QuetesValides>().AllQuetesBien())
        {
            Debug.Log("le bouton est apparu � droite.");
        }
    }

    public void InterrogerTemoin() //update le compteur de t�moins int�rrog�s
    {

        TemoinsInterroges += 1;
        Quete.text = original + "(" + TemoinsInterroges + "/" + NbTemoins + ")";
        if (TemoinsInterroges == NbTemoins)
        {
            ValiderQuete();
        }
    }
    
}
