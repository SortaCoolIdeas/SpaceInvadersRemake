using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileScript : MonoBehaviour
{
    public LogicScript logic;
    private float deadZone = 10;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + ((Vector3.up * 10) * Time.deltaTime);

        if (transform.position.y > deadZone)
        {
            Destroy(gameObject);
        }
    }
}
