using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gUi : MonoBehaviour
{
    private AudioSource Audio;
    private void Start() {
        Audio = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioSource>();
    }
    public void Restart()
    {
        SceneManager.LoadScene(1);
    }
    public void Quit()
    {
        Application.Quit();
    }
    public void Menu()
    {
        SceneManager.LoadScene(0);
        Destroy(Audio.gameObject);
    }
}
