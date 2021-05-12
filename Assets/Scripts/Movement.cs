using UnityEngine;

public class Movement : MonoBehaviour
{
    private float speed;
    private bool selected;

    public TuchPad touch;
    // Start is called before the first frame update
   /*
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
    }*/
    void Update()
    {
        Vector2 direction = touch.GetDir();
            this.transform.Translate(0, direction.y, 0);
    }
}
