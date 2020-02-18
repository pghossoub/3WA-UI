using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Play : MonoBehaviour
{
    public GameEvent myEvent;
    private void Start()
    {
        myEvent.Raise();
    }
}
