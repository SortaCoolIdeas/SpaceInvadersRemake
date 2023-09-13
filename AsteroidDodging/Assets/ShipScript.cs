using UnityEngine;

public class ShipScript : MonoBehaviour
{
    public Rigidbody2D myShip;
    public Rigidbody2D projectile;
    public float driftStrength;
    public LogicScript logic;
    public bool shipIsWorking = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A) && shipIsWorking) 
        {
            myShip.velocity = Vector3.left * driftStrength;
        }
        if (Input.GetKeyDown(KeyCode.D) && shipIsWorking)
        {
            myShip.velocity = Vector3.right * driftStrength;
        }
        if (Input.GetKeyDown(KeyCode.Space) && shipIsWorking)
        {
            fireProjectile();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        shipIsWorking = false;
    }

    private void fireProjectile()
    {
        float heightOffset = transform.position.y + 1f;
        Instantiate(projectile, new Vector3(transform.position.x, heightOffset, 0), transform.rotation);
    }
}
