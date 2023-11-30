using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class RandomBloodButton : MonoBehaviour
{
    public TMP_Text randomresult;
    public GameObject buttonParent;
    public GameObject panelwrong;
    public GameObject panelgood;

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

    public void BloodButtonClick(GameObject self)
    {

            if (self.GetComponent<TMP_Text>().text == randomresult.text)
            {
                panelgood.SetActive(true);
            }
            else
            {
                panelwrong.SetActive(true);
            }
    }
    //canvas groupe
    //Pour chaque button , si le texte est ==  au texte du boutton, alors ouvrir le bon panel, sinon ouvrir mauvais 

}
