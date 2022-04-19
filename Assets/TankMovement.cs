using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankMovement : MonoBehaviour
{

    private Rigidbody2D rigidBody;
    private Transform transform;

    public GameObject rocket;
    public bool Dead = false;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody2D>();
        transform = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Dead == true)
            return;
        Vector2 currentPosition = rigidBody.position;
        if (Input.GetKey(KeyCode.W))
        {
            if (rigidBody.position.y < 5.4f)
            {
                rigidBody.MovePosition(currentPosition + new Vector2(0, 0.1f));
                transform.eulerAngles = new Vector3(0, 0, 0);
            }
        }
        if (Input.GetKey(KeyCode.A))
        {
            if (rigidBody.position.x > -11.7)
            {
                rigidBody.MovePosition(currentPosition + new Vector2(-0.1f, 0));
                transform.eulerAngles = new Vector3(0, 0, 90);
            }
        }
        if (Input.GetKey(KeyCode.S))
        {
            if (rigidBody.position.y > -5.5f)
            {
                rigidBody.MovePosition(currentPosition + new Vector2(0, -0.1f));
                transform.eulerAngles = new Vector3(0, 0, 180);
            }
        }
        if (Input.GetKey(KeyCode.D))
        {
            if (rigidBody.position.x < 11.7f)
            {
                rigidBody.MovePosition(currentPosition + new Vector2(0.1f, 0));
                transform.eulerAngles = new Vector3(0, 0, 270);
            }
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject newRocket = Instantiate(rocket);
            newRocket.transform.position = rigidBody.position;
            newRocket.GetComponent<Move>().started = true;
            newRocket.transform.eulerAngles = rigidBody.transform.eulerAngles;
            newRocket.GetComponent<SpriteRenderer>().sortingLayerName = "Gun";
        }
    }
}
