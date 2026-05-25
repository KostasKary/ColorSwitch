using UnityEngine;
using UnityEngine.SceneManagement;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public float jumpForce = 10f;
    public Rigidbody2D rb;
    public SpriteRenderer sr;
    public float speed = 100f;
    public string currentColor;
    public Color Blue;
    public Color Pink;
    public Color Yellow;
    public Color Purple;

    void setrandomcolor()
    {
        int index = Random.Range(0, 4);

        if (index == 0)
        {
            currentColor = "Blue";
            sr.color = Blue;
        }
        else if (index == 1)
        {
            currentColor = "Yellow";
            sr.color = Yellow;
        }
        else if (index == 2)
        {
            currentColor = "Purple";
            sr.color = Purple;
        }
        else if (index == 3)
        {
            currentColor = "Pink";
            sr.color = Pink;    
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        setrandomcolor();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Jump") || Input.GetMouseButtonDown(0))
        {
            rb.linearVelocity = Vector2.up * jumpForce;
        }
        transform.Rotate(0f, 0f, speed * Time.deltaTime);   
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag=="Color Changer")
        {
            setrandomcolor();
            Destroy(collision.gameObject);
            return;
        }

        if (collision.name!=currentColor)
        {
            Debug.Log("Game Over");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        }
    }
}