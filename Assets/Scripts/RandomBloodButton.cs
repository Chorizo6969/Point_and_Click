using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class RandomBloodButton : MonoBehaviour
{
    public TMP_Text randomresult;

    List<string> randomButton = new List<string> { "O+", "O-", "A+", "A-", "B+", "B-", "AB+", "AB-" };

    public void ButtonClick()
    {
        Debug.Log("jsdbviosd");
        PrintBlood();
    }

    private void PrintBlood()
    {
        string randomName = randomButton[Random.Range(0, randomButton.Count)];
        randomresult.text = randomName;
    }











    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
