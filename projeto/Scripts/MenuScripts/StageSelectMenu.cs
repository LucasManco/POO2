using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StageSelectMenu : MonoBehaviour, MenuInterface
{
    public GameObject content;
    public MenuController MC;

    public void PlayGame(int index)
    {
        MC.setMenu("play");
        SceneManager.LoadScene(index);

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
        Debug.Log("StageSelect State");
        return "selectMenu";
    }

    public bool Pauseable()
    {
        return false;
    }
}
