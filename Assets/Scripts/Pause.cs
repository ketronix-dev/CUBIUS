using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pause : MonoBehaviour
{
    private bool show = false;
    [SerializeField] private GameObject PauseObj;
    [SerializeField] private Text button;
    public void ShowAndUnShow()
    {
        if (show != true)
        {
            show = true;
            Time.timeScale = 0;
            PauseObj.SetActive(true);
            button.text = "Resume";
        }
        else
        {
            show = false;
            Time.timeScale = 1;
            PauseObj.SetActive(false);
            button.text = "Pause";
        }
    }
}
