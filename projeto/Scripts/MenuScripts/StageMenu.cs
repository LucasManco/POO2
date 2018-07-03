using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StageMenu : MonoBehaviour, MenuInterface
{

    public GameObject content;
  

    public void Update()
    {
    }
    public void BackMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("FaseMain");
    }

    
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
        Debug.Log("Stage State");
        return "stage";
    }

    public bool Pauseable()
    {
        return true;
    }
}
