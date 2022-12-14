using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RunController : MonoBehaviour
{
    [SerializeField] private float speed;

    [SerializeField] private GameObject MenuRestart;
    [SerializeField] private Text MaxScores;
    [SerializeField] private Text CurScore;
    [SerializeField] private GameObject hide1;
    [SerializeField] private GameObject hide2;
    void Update()
    {
        if (this.transform.position.y <= -1f)
        {
            MenuOver_Fall();
        }
        this.transform.Translate(-speed * Time.deltaTime, 0, 0);
    }
    public void MenuOver_Fall()
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
