using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class restarter : MonoBehaviour
{
    public GameObject MenuRestart;
    public Text EndScores;
    public Counter score;
    public Text CurScore;
    public GameObject hide1;
    public GameObject hide2;

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            EndScores.text = PlayerPrefs.GetInt("Score").ToString();
            CurScore.text = score.ScoreText.ToString();
            int scoresToSave = int.Parse(score.ScoreText.ToString());
            if(scoresToSave > PlayerPrefs.GetInt("Score"))
            {
                PlayerPrefs.SetInt("Score", scoresToSave);
            }
            MenuRestart.SetActive(true);
        }
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void Quit()
    {
        Application.Quit();
    }
    public void Menu()
    {
        SceneManager.LoadScene(0);
    }
}
