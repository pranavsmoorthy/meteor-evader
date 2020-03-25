using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteor : MonoBehaviour
{
    public ParticleSystem explosionEffect;
    public GameObject Player;
    public GameObject meteor;
    float xcor;
    public float fallSpeed = 5;

    // Start is called before the first frame update
    void Start()
    {
        if (transform.position.y == -1000 && transform.position.x == -1000)
        {
            return;
        }
        xcor = Random.Range(-13, 13);
        transform.position = new Vector3(xcor, 5);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * fallSpeed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Object.Destroy(meteor);
    }
}
