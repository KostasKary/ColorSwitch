using UnityEngine;

public class rotation1 : MonoBehaviour
{
    public float speed = 200f;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, 0f, speed * Time.deltaTime);
    }
}
