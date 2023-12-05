using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomBombe : MonoBehaviour
{
    [SerializeField] List<GameObject> ListeBombesPotentielles = new List<GameObject>();
    private void Start()
    {
        ListeBombesPotentielles[Random.Range(0, 5)].SetActive(true);
    }
}
