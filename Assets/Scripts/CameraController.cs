using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private GameObject Player;
    [SerializeField] private float speed;
    void Update()
    {
        if (Player.transform.position.x <= this.transform.position.x - 8)
        {
            this.transform.Translate(-speed * Time.deltaTime, 0, 0);
        }
    }
}
