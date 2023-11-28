using UnityEngine;

public class ChangeCursor : MonoBehaviour
{
    public Texture2D cursorTexture; // Nouvelle texture du curseur
    public Vector2 hotSpot = Vector2.zero; // Position du point chaud du curseur
    public float sensitivity = 10f; // Sensibilité de détection sur la droite de l'écran

    void Start()
    {
        Cursor.SetCursor(cursorTexture, hotSpot, CursorMode.Auto);
    }

    void Update()
    {
        //plutôt un gameobject histoire de mettre une loupe
    }
}