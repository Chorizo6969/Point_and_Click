using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class RandomPrint : MonoBehaviour
{
    public TMP_Text randomresult;
    public GameObject buttonParent;
    public GameObject PanelWrong;
    public GameObject PanelGood;

    List<string> RandomButton = new List<string> { "Empreinte 1", "Empreinte 2", "Empreinte 3", "Empreinte 4", "Empreinte 5", "Empreinte 6", "Empreinte 7", "Empreinte 8" };

    public void ButtonClick()
    {
     PrintPrint();
     Debug.Log("B");
    }

    private void PrintPrint()
    {
        string randomName = RandomButton[Random.Range(0, RandomButton.Count)];
        randomresult.text = randomName;
    }

    public void Update(){
        
    }

    public void PrintButtonClick(GameObject self)
    {

          if (self.GetComponent<TMP_Text>().text == randomresult.text)
          {
               PanelGood.SetActive(true);
               Debug.Log("C");
          }
            else
            {
               PanelWrong.SetActive(true);
               Debug.Log("D");
            }
    }
}
