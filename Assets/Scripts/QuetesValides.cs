using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuetesValides : MonoBehaviour
{
    [SerializeField]private List<GestionQuetes> ListeGestionQuetes= new List<GestionQuetes>();
    public GameObject ObjetActif;
    public GameObject ObjetInactif;
    public bool DesactiverObjet;
    public bool AllQuetesBien()
    {
        bool resultat = true;
        foreach(GestionQuetes quete in ListeGestionQuetes)
        {
            resultat = resultat && quete.isDone;
        }
        return resultat;
    }
    private void Update()
    {
        if (AllQuetesBien())
        {
            if (DesactiverObjet)
            {
                ObjetInactif.SetActive(false);
            }
            ObjetActif.SetActive(true);
        }
    }
}
