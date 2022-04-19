using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToGoal : MonoBehaviour
{

    private GameObject Goal;
    public float SpaceBetween = 1.5f;

    void Update()
    {
        GameObject[] goals = GameObject.FindGameObjectsWithTag("Player");
        Goal = goals[0];
        if (Vector3.Distance(Goal.transform.position, transform.position) >= SpaceBetween)
        {
            Vector3 direction = Goal.transform.position - transform.position;
            transform.Translate(direction * Time.deltaTime);
        }
    }

}
