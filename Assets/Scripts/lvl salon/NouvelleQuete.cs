using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NouvelleQuete : MonoBehaviour
{
    public void Ajouterquete()
    {
        GameObject quete = new GameObject();
        quete.transform.position = new Vector2(0, 42);
        quete.AddComponent<TextMesh>();
    }
}
