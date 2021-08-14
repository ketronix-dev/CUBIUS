using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    [SerializeField] private GameObject MenuRestart;
    [SerializeField] private Text MaxScores;
    [SerializeField] private Text CurScore;
    [SerializeField] private GameObject hide1;
    [SerializeField] private GameObject hide2;

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
        MaxScores.text = "Max scores:" + PlayerPrefs.GetInt("Score").ToString();
        CurScore.text = "Your scores:" + Counter.score.ToString();
        Time.timeScale = 0;
        int scoresToSave = Counter.score;
        if (scoresToSave > PlayerPrefs.GetInt("Score"))
            {
                PlayerPrefs.SetInt("Score", scoresToSave);
            }
    }
}
