using System.Collections;
using UnityEngine;

public class Game_Manager : MonoBehaviour
{
    [Header("Sistema de Frutas")]
    [SerializeField]
    private GameObject selected_fruit,SP;
    public GameObject[] fruits_to_Spawn;
    private Rigidbody2D rb;
    private void Start()
    { 
     rb = selected_fruit.GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ADDG();
            StartCoroutine(CF());
        }
    }

    IEnumerator CF()
    {
        yield return new WaitForSeconds(0.5f);
        int cx = Random.Range(0, 3);
        selected_fruit = Instantiate(fruits_to_Spawn[cx], SP.transform.position, Quaternion.identity);
        rb = selected_fruit.GetComponent<Rigidbody2D>();
    }
    void ADDG()
    {
        rb.gravityScale = 1f;
    }
}
