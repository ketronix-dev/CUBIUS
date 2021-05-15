using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public GameObject MenuRestart;
    public Text EndScores;
    public Text CurScore;
    public GameObject hide1;
    public GameObject hide2;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            MenuOver();
        }
    }
    public void MenuOver()
    {
        MenuRestart.SetActive(true);
        hide1.SetActive(false);
        hide2.SetActive(false);
        Time.timeScale = 0;
        int scoresToSave = Counter.score;
        if (scoresToSave > PlayerPrefs.GetInt("Score"))
            {
                PlayerPrefs.SetInt("Score", scoresToSave);
            }
    }
}
