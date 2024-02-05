using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour
{
    public GameObject obj_boton,obj_cleanf,obj;
    

    private void OnTriggerEnter2D(Collider2D c)
    {
        c.gameObject.GetComponent<Rigidbody2D>().gravityScale = 1;
    }

    public void Desativar()
    {
        obj.SetActive(false);
        obj_boton.SetActive(true);
    }

    public void Clean_Boton()
    {
        StartCoroutine(clean());
    }

    IEnumerator clean()
    {   obj_cleanf.SetActive(true);
        yield return new WaitForSeconds(0.01f);
        obj_cleanf.SetActive(false);
    }
}
