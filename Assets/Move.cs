using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    private Rigidbody rb;
    private Transform trf;
    private float speed = 5f;
    private float startTime;


    public bool started = false;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        trf = GetComponent<Transform>();
        startTime = Time.fixedTime;
    }

    // Update is called once per frame
    void Update()
    {
        trf.position += trf.up * Time.deltaTime * speed;
        if (started && (Time.fixedTime - startTime) > 10)
        {
            Destroy(GetComponent<GameObject>());
        }
    }
}
