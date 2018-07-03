using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGameMenu : MonoBehaviour, MenuInterface
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
        Debug.Log("Stage EndGame");
        return "EndGame";
    }

    public bool Pauseable()
    {
        return false;
    }
}
