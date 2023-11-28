using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour

{
    public GameObject target;
    public Vector3 mousePositionInGame;

    private void mouseLocation()
    {
        Vector3 mousePositionOnScreen = Input.mousePosition;

        mousePositionInGame = new Vector3(mousePositionOnScreen.x, mousePositionOnScreen.y);

        target.transform.position = mousePositionOnScreen;

    }
    void Start()
    {
        

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
