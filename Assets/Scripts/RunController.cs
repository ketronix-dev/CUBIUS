using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RunController : MonoBehaviour
{
    public float speed;
    void Update()
    {
        if (this.transform.position.y <= -1f)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        this.transform.Translate(-speed * Time.deltaTime, 0, 0);
    }
}
