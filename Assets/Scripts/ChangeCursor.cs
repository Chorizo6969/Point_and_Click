using UnityEngine;

public class ChangeCursor : MonoBehaviour
{
    public Texture2D cursorTexture; // Nouvelle texture du curseur
    public Vector2 hotSpot = Vector2.zero; // Position du point chaud du curseur
    public float sensitivity = 10f; // Sensibilité de détection sur la droite de l'écran

    void Start()
    {
        Cursor.visible = false; // Masquer le curseur par défaut
    }

    void Update()
    {
        // Vérifier si la souris est sur la droite de l'écran
        if (Input.mousePosition.x >= Screen.width - sensitivity)
        {
            // Changer la texture du curseur
            Cursor.SetCursor(cursorTexture, hotSpot, CursorMode.ForceSoftware);
            Cursor.visible = true; // Rendre le curseur visible
        }
        else
        {
            // Revenir au curseur par défaut
            Cursor.SetCursor(null, Vector2.zero, CursorMode.Auto);
            Cursor.visible = false; // Masquer le curseur
        }
    }
}
