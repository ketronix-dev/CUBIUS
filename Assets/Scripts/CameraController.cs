using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject Player;
    public float speed;
    void Update()
    {
        if (Player.transform.position.x <= this.transform.position.x - 5)
        {
            this.transform.Translate(-speed * Time.deltaTime, 0, 0);
        }
    }
}
