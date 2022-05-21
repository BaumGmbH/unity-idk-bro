using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public GameObject obstade;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == obstade.tag)
        {
            Debug.Log("Yay");
        }
    }
}
