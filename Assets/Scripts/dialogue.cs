using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.UIElements;
using System.Diagnostics.Tracing;
using System;

public class dialogue : MonoBehaviour
{
    public TMP_Text monTexte;
    public string texte;
    Coroutine maCoroutine;
    public float Delay;
    private int Compte = 0;
    public List<string> dialogueList;
    public GameObject fauxPanel;

    private string current;

    bool isPressed;
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (isPressed)
            {
                ModifierTexte();
                AfficheTexte();
            }
        }

        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            if (maCoroutine != null)
            {
                StopCoroutine(maCoroutine);
            }
            monTexte.maxVisibleCharacters = monTexte.text.Length;
        }
    }

    public void Activate()
    {
        isPressed = true;
        current = (dialogueList[Compte]);
        Compte++;
        AfficheTexte();
    }

    private void ModifierTexte()
    {
        if (Compte > dialogueList.Count)
        {
            Debug.Log("liste finie");
        }
        if (Compte == dialogueList.Count)
        {
            current = "";
            fauxPanel.SetActive(false);
            isPressed = false;
            Compte = 0;
            Destroy(gameObject);
        }
        else
        {
            current = (dialogueList[Compte]);
            Compte++;
        }
    }

    public void AfficheTexte()
    {
        
        monTexte.text = current;
        monTexte.maxVisibleCharacters = 0;
        maCoroutine = StartCoroutine(TexteLettreParLettre());
    }

    /*IEnumerator Attente(float delai)
    {
        yield return new WaitForSeconds(delai);
    }*/

    public void OnDisable()
    {
        monTexte.text = null;
    }

    IEnumerator TexteLettreParLettre()
    {
        for (int i = 0; i <= monTexte.text.Length; i++)
        {
            monTexte.maxVisibleCharacters++;
            yield return new WaitForSeconds(Delay);
        }
    } 
}




/* if (Compte == 1 )
            {
                StopCoroutine(maCoroutine);
                monTexte.maxVisibleCharacters = monTexte.text.Length;
            }

            if (Compte == 2 )
            {
                monTexte.text = null;
            } */


//Bonsoir, je suis un gars qui dois écrire un truc vla long sa mere la pute car ma zone est VLA LONGUE SA MERE LA PUTE et du coup je dis écrire dans le vide, j'adore :D Sinon ça va, je suis content j'ai pas de courbature, truc de zinzito LOLOLOL