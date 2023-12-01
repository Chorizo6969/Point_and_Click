using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Flashlight : MonoBehaviour

{
     public GameObject target;
   
     private Camera cam;

    public void TargetObject()
    {

    }
    void Start()
    {
        cam = Camera.main;
       // Eteindre();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    void OnGUI()
    {
        //fais avec la doc unity
        Vector3 point = new Vector3();
        Event currentEvent = Event.current;
        Vector2 mousePos = new Vector2();

        mousePos.x = currentEvent.mousePosition.x;
        mousePos.y = cam.pixelHeight - currentEvent.mousePosition.y;

        point = cam.ScreenToWorldPoint(new Vector3(mousePos.x, mousePos.y, cam.nearClipPlane));
        target.transform.position = mousePos;
    }
    public void Eteindre()
    {
        this.gameObject.GetComponent<Image>().color = Color.black;

    }
}
