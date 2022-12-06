using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);   //Plays next scene in array index
    }

    public void QuitGame()
    {
        Debug.Log ("QUIT!");     // Just to let me know while in the editor that it works
        Application.Quit();     // Quits the game while on .exe
    }
}
