using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish_Game : MonoBehaviour
{
    [SerializeField] GameObject F_obj;
    private Finish_Game fg;

    private void Start()
    {
        fg = this;
    }
    private void OnTriggerEnter2D(Collider2D c)
    {
        if(c.tag == "Melão")
        {
            F_obj.SetActive(true);
            fg.enabled = false;
        }
    }
}
