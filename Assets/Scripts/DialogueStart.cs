using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DialogueStart : MonoBehaviour
{
    public GameObject Cache;
    private void OnEnable()
    {
        gameObject.GetComponent<dialogue>().Activate();
        Cache.SetActive(true);
    }


}
