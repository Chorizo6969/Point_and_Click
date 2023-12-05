using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject ActiverObjet;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ActiverObjet.SetActive(true);
            gameObject.SetActive(false);
            GameObject.Find("quete 1").GetComponent<GestionQuetes>().ValiderQuete();
        }
    }
}
