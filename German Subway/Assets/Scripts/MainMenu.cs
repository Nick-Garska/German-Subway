using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


// Add this script to MainMenu in Menu Scene
public class MainMenu : MonoBehaviour
{
    // Add this function to PlayButton in Inspector under OnClick()
    // drag MainMenu into noneObj
    // and choose fuction name under MainMenu() > PlayGame()  
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }


    // Add this function to QuitButton in Inspector under OnClick()
    // drag MainMenu into noneObj
    // and choose fuction name under MainMenu() > QuitGame()
    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();

    }
}