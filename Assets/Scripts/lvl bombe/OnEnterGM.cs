using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OnEnterGM : MonoBehaviour, IPointerEnterHandler
{
    public GameObject objetActiver;
    public void OnPointerEnter(PointerEventData eventData)
    {
        GameObject.Find("Nb_chances").GetComponent<ChancesRestantes>().ReduireNbChances();
        objetActiver.SetActive(true);
        
    }

 
}
