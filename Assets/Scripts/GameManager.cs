using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Event myEvent;

    public Texture2D m_texture;

    public void Awake()
    {
        Cursor.SetCursor(m_texture, new Vector2(0,1), CursorMode.Auto);
    }
    public void Response()
    {
        Debug.Log("Response to Event !");
    }

}
