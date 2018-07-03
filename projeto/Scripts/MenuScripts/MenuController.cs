using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuController : MonoBehaviour {
    //State Pattern
    public static bool isPaused = false;
    public Text winText;

    public MainMenu main;                      
    public StageSelectMenu selectMenu;         //Menu where player chan select the stage 
    public ControlsMenu controls;              //Menu for change de keybinds of the game
    public SettingsMenu settings;              //Menu for change de settings of the game
    public StageMenu stage;
    public PlayMenu play;                      //Void menu for gamming state
    public EndGameMenu end;
    public MenuInterface currentMenu;

    

    void Awake()
    {
        if (winText != null) {
            winText.text = " ";
        }
            

            Debug.Log("MenuController == null");
            SceneManager.activeSceneChanged += OnSceneChanged;
     }

    // Use this for initialization
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && currentMenu.Pauseable())
        {
            Debug.Log("Apertou ESC e currentMenu = " + currentMenu.GetType());
            switch (currentMenu.GetState())
            {
                case "play":
                    Pause();
                    break;
                case "stage":
                    Resume();
                    break;
                case "Settings":
                    backButton();
                    break;
                case "controls":
                    setMenu("settings");
                    break;
            }
        }
    }


    public void Resume()
    {
        Debug.Log("Resume");
        setMenu("play");
        Time.timeScale = 1f;
        isPaused = false;
               
    }

    private void Pause()
    {
        Debug.Log("Pause");
        setMenu("stage");
        Time.timeScale = 0f;
        isPaused = true;
    }

    public void Restart()
    {
        Debug.Log("Restart");
        setMenu("play");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1f;
        isPaused = false;
    }

    public void QuitGame()
    {
        isPaused = false;
        Debug.Log("Quit");
        Application.Quit();
    }


    public void backButton()
    {
        if (isPaused)
        {
            setMenu("stage");
        }
        else
        {
            setMenu("main");
        }

    }

    public void WinGame()
    {
        isPaused = true;
        Time.timeScale = 0f;
        winText.text = "You Win";
        setMenu("end");

    }
    public void LoseGame()
    {
        isPaused = true;
        Time.timeScale = 0f;
        winText.text = "Lose";
        setMenu("end");

    }

    void OnSceneChanged(Scene previousScene, Scene changedScene)
    {
        Debug.LogError("OnSceneChanged changedScene = " + changedScene.name);
        switch (changedScene.name)
        {
            case "Main":
                isPaused = false;
                Debug.Log("main");
                getScripts();
                setMenu("main");
                Debug.Log(currentMenu.GetState());
                break;
            case "Fase1":
                isPaused = false;
                Debug.Log("play");
                getScripts();
                setMenu("play");
                Debug.Log(currentMenu.GetState());
                break;
            case "Fase2":
                isPaused = false;
                Debug.Log("play");
                getScripts();                
                setMenu("play");
                Debug.Log(currentMenu.GetState());
                break;
            case "FaseMain":
                isPaused = false;
                Debug.Log("main");
                getScripts();
                setMenu("main");
                Debug.Log(currentMenu.GetState());
                break;
            case "Fase3":
                isPaused = false;
                Debug.Log("play");
                getScripts();
                setMenu("play");
                Debug.Log(currentMenu.GetState());
                break;
        }

    }

    public void getScripts()
    {
        main = GameObject.Find("MainMenu").GetComponent<MainMenu>();
        selectMenu = GameObject.Find("SelectStageMenu").GetComponent<StageSelectMenu>();
        controls = GameObject.Find("ControlsMenu").GetComponent<ControlsMenu>();
        settings = GameObject.Find("SettingsMenu").GetComponent<SettingsMenu>();
        stage = GameObject.Find("StageMenu").GetComponent<StageMenu>();
        play = GameObject.Find("GameManager").GetComponent<PlayMenu>();
        end = GameObject.Find("EndGame").GetComponent<EndGameMenu>();
    }
   
    public void setMenu(string menu)
    {
        main.Deactivate();
        selectMenu.Deactivate();
        controls.Deactivate();
        settings.Deactivate();
        stage.Deactivate(); ;
        end.Deactivate(); ;
        play.Deactivate();
        switch (menu)
        {
            case "main":
                Debug.Log("set main");
                currentMenu = main;
                currentMenu.Activate();
                break;
            case "selectMenu":
                Debug.Log("set selectMenu");
                currentMenu = selectMenu;
                currentMenu.Activate();
                break;
            case "controls":
                Debug.Log("set controls");
                currentMenu = controls;
                currentMenu.Activate();
                break;
            case "settings":
                Debug.Log("set settings");
                currentMenu = settings;
                currentMenu.Activate();
                break;
            case "stage":
                Debug.Log("set stage");
                currentMenu = stage;
                currentMenu.Activate();
                break;
            case "play":
                Debug.Log("set play");
                currentMenu = play;
                currentMenu.Activate();
                break;
            case "end":
                Debug.Log("set end");
                currentMenu = end;
                currentMenu.Activate();
                break;
        }
    }


}
