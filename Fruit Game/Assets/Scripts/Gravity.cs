using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D c)
    {
        c.gameObject.GetComponent<Rigidbody2D>().gravityScale = 1;
    }
}
