using UnityEngine;

public class Movement : MonoBehaviour
{
    private float speed;
    private bool selected;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void Left()
    {
        if (selected != true)
        {
            selected = true;
        }
        speed = 5;
    }
    public void Right()
    {
        if (selected != true)
        {
            selected = true;
        }
        speed = -5;
    }
    public void UnLeft()
    {
        selected = false;
    }
    public void UnRight()
    {
        selected = false;
    }
    void Update()
    {
        if (selected == true)
        {
            this.transform.Translate(0, speed * Time.deltaTime, 0);
        }
        else
        {
            speed = 0;
        }
    }
}
