using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CursorDetector : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{

    public Texture2D cursorTexture; // Nouvelle texture du curseur

    public Texture2D main_cursorTexture; // Nouvelle texture du curseur

    public Vector2 hotSpot = Vector2.zero; // Position du point chaud du curseur

    public float sensitivity = 10f; // Sensibilité de détection sur la droite de l'écran


    public void OnPointerEnter(PointerEventData eventData)
    {
        Cursor.SetCursor(cursorTexture, hotSpot, CursorMode.Auto);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Cursor.SetCursor(main_cursorTexture, hotSpot, CursorMode.Auto);
    }
}
