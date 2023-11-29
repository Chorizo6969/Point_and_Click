using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

using UnityEngine.UI;
using static UnityEngine.GraphicsBuffer;
public class Light : MonoBehaviour

{
    private Camera cam;
    public GameObject target;
    public void eteindre() 
    {
        this.gameObject.GetComponent<Image>().color = Color.black;

    }

   
   public void OnGUI()
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
 public void allumer()

    {
      
        
           
            
            
            }


    void Start()
    {
        // eteindre();
        cam = Camera.main;
    }

   
    void Update()
    {
        
    }
}
