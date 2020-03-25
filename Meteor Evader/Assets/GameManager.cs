using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Rigidbody Meteor;
    float cloneRate;
    float nextClone;

    // Start is called before the first frame update
    void Start()
    {
        cloneRate = 0.5f;
        nextClone = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        CheckIfTimeToClone();
    }

    void CheckIfTimeToClone()
    {
        if (Time.time > nextClone)
        {
            Rigidbody clone;
            clone = Instantiate(Meteor, transform.position, transform.rotation);
            nextClone = Time.time + cloneRate;
        }
    }
}
