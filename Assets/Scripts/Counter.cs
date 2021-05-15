using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Counter : MonoBehaviour
{
    public Text ScoreText;
	public GameObject Player;
    [HideInInspector]
	public static int score;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
       
        score = Mathf.RoundToInt(-1 * Player.transform.position.x);
        if (score >= 0)
        {
            ScoreText.text = score.ToString();
        }
    }
}
