using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_MainMenu : MonoBehaviour
{
    public GameObject MainMenu;

    // Start is called before the first frame update
    void Start()
    {
        MainMenu.SetActive(true);
    }

    public void PlayNowButton()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("GameLevel");
    }

    public void SettingsButton()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Settings");
    }

    public void QuitButton()
    {
        // Quit Game
        Application.Quit();
    }
}