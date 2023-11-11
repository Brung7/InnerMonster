using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Threading;

public class MainMenuActivator : MonoBehaviour
{
    public Button escape;
    public Button desktop;
    public bool EscapeMenuOpen;

 
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            
            if (EscapeMenuOpen == false)
            {
                Time.timeScale = 0f;
                EscapeMenuOpen = true;
                escape.gameObject.SetActive(true);
                desktop.gameObject.SetActive(true);
            }
            else
            {
                Time.timeScale = 1f;
                EscapeMenuOpen = false;
                escape.gameObject.SetActive(false);
                desktop.gameObject.SetActive(false);
            }
        }
    }


    public void GoToMenu()
    {
        SceneManager.LoadScene(1);
    }

    public void GoToDesktop()
    {
        Application.Quit();
    }
}
