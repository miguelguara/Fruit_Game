using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    [SerializeField] string Tags;

    private void OnTriggerEnter2D(Collider2D c)
    {
        if(c.tag != Tags)
        Destroy(c.gameObject);
    }
}
