using UnityEngine;

public class Movement : MonoBehaviour
{
    private float speed;
    private bool selected;

    public TuchPad touch;
    void Update()
    {
        Vector2 direction = touch.GetDir();
            this.transform.Translate(0, ((direction.x * -3) * Time.deltaTime), 0);
    }
}
