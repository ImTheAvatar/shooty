using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehaviour : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        print("hit "+other.name);

        gameObject.SetActive(false);
    }
    private void OnCollisionEnter(Collision collision)
    {
        print("hit " + collision.gameObject.name);
        gameObject.SetActive(false);
    }

}
