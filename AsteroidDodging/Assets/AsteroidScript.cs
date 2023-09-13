using UnityEngine;

public class AsteroidScript : MonoBehaviour
{
    public Rigidbody2D myAsteroid;
    public float gravModifier = 5;
    public float deadZone = -7;
    public LogicScript logic;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + ((Vector3.down * gravModifier) * Time.deltaTime);
        
        if (transform.position.y < deadZone)
        {
            Destroy(gameObject);
        }
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer != 6) 
        {
            logic.addScore(5);
        }
        Destroy(gameObject);
    }
}
