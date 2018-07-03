using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour, MenuInterface
{
    public GameObject content;

	    public void Activate()
    {
        content.SetActive(true);
    }

    public void Deactivate()
    {
        content.SetActive(false);
    }

    public string GetState()
    {
        Debug.Log("Main State");
        return "main";
    }

    public bool Pauseable()
    {
        return false;
    }
}
