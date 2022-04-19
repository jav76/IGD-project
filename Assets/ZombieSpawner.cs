using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieSpawner : MonoBehaviour
{
    public GameObject SpawnObject;
    private float nextSpawn;
    public float maxRandom = 10f;
    public float interval = 15f;
    private float nextDecrease = 30f;
    // Start is called before the first frame update
    void Start()
    {
        nextSpawn = Random.Range(0, maxRandom);
    }

    // Update is called once per frame
    void Update()
    {
        
        if (maxRandom > 1f && Time.time > nextDecrease)
        {
            nextDecrease = Time.time + interval;
            maxRandom -= 1f;
        }

        if (nextSpawn <= Time.time)
        {
            GameObject zombie = Instantiate(SpawnObject);
            zombie.transform.position = transform.position;
            zombie.GetComponent<SpriteRenderer>().sortingLayerName = "Gun";
            nextSpawn = Time.time + Random.Range(0f, maxRandom);
        }
    }
}
