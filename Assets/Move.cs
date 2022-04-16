using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    private Rigidbody rb;
    private Transform trf;
    private float speed = 15f;
    private float startTime;


    public bool started = false;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        trf = GetComponent<Transform>();
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        trf.position += trf.up * Time.deltaTime * speed;
        if (started == true && (Time.time - startTime) > 4)
        {
            Destroy(gameObject);
        }
    }
}
