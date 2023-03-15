using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void restartlvl()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void quit()
    {
        Debug.Log("krsna");
        Application.Quit();
    }
}
