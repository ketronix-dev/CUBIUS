using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject AuthorsPanel;
    private bool show;
    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void Authors()
    {
        if (show == true)
        {
            AuthorsPanel.SetActive(false);
            show = false;
        }
        else if (show == false)
        {
            AuthorsPanel.SetActive(true);
            show = true;
        }
    }
    public void Quit()
    {
        Application.Quit();
    }
}
