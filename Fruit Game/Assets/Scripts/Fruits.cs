using UnityEditor;
using UnityEngine;

public class Fruits : MonoBehaviour
{

    private Rigidbody2D rb;
    public string Tag;
    private Fruits_Combinations c;
    // Start is called before the first frame update

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        c = FindObjectOfType<Fruits_Combinations>();
    }
    private void Update()
    {
        Vector2 mv = new Vector2(Input.GetAxisRaw("Horizontal"), 0f);
        if(rb.gravityScale <= 0)
        {
            transform.Translate(mv * 4 * Time.deltaTime,Space.World);
        }
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == Tag)
        {
            c.C_fruta(Tag, transform);
            Destroy(this.gameObject);
        }
    }
}
