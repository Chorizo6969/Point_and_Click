using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.UIElements;

public class dialogue : MonoBehaviour
{
    public TMP_Text monTexte;
    public string texte;
    public float delay;
    Coroutine maCoroutine;

    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown)
        {
            StopCoroutine(maCoroutine);
            monTexte.maxVisibleCharacters = monTexte.text.Length;
        }
    }

    public void afficheTexte(string text)
    {
        texte = text;
        monTexte.text = texte;
        monTexte.maxVisibleCharacters = 0;
        maCoroutine = StartCoroutine(texteLettreParLettre());
    }

    public void OnEnable()
    {

    }

    public void OnDisable()
    {
        monTexte.text = null;
    }

    IEnumerator texteLettreParLettre()
    {
        for (int i = 0; i <= monTexte.text.Length; i++)
        {
            monTexte.maxVisibleCharacters++;
            yield return new WaitForSeconds(delay);
        }
    }
    

}