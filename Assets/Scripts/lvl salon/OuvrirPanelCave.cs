using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject ActiverObjet;
    public GameObject ObjetDialogue;
    public GameObject ObjetDesactiver;
    public GameObject ObjetDesactiver2;
    public GameObject ObjetDesactiver3;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ActiverObjet.SetActive(true);
            ObjetDialogue.SetActive(true);
            ObjetDesactiver.SetActive(false);
            ObjetDesactiver2.SetActive(false);
            ObjetDesactiver3.SetActive(false);
            GameObject.Find("quete 2").GetComponent<GestionQuetes>().ValiderQuete();
        }
    }
}
