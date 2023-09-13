using UnityEngine;

public class AsteroidSpawnerScript : MonoBehaviour
{
    public GameObject asteroid;
    public float spawnRate;
    private float spawnTimer = 0;
    private float timer = 0;
    public float widthOffset;
    public ShipScript ship;
    public int playerScore;
    public LogicScript logic;

    // Start is called before the first frame update
    void Start()
    {
        spawnAsteroid();
    }

    // Update is called once per frame
    void Update()
    {
        if (ship.shipIsWorking) 
        {
            if (timer < 10)
            {
                timer += Time.deltaTime;
            }
            else
            {
                logic.adjustSpawnRate();
                timer = 0;
            }
            if (spawnTimer < spawnRate)
            {
                spawnTimer += Time.deltaTime;
            }
            else
            {
                spawnAsteroid();
                spawnTimer = 0;
            }
        }
    }

    void spawnAsteroid()
    {
        float leftMostPoint = transform.position.x - widthOffset;
        float rightMostPoint = transform.position.x + widthOffset;

        Instantiate(asteroid, new Vector3(UnityEngine.Random.Range(leftMostPoint, rightMostPoint), transform.position.y, 0), transform.rotation);
    }
}
