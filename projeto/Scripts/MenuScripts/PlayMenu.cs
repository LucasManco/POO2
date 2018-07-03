using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayMenu : MonoBehaviour, MenuInterface
{
    public void Activate()
    {
        
    }

    public void Deactivate()
    {
        
    }

    public string GetState()
    {
        Debug.Log("Play State");
        return "play";
    }

    public bool Pauseable()
    {
        return true;
    }
}
