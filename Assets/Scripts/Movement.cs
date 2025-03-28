using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float moveSpeed = 5f;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private SpriteRenderer sp;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sp = GetComponent<SpriteRenderer>();
    }
    void Update()
    {

        float vertical = Input.GetAxisRaw("Vertical");
        float horizontal = Input.GetAxisRaw("Horizontal");
        Vector2 BasicMovement = new Vector2(horizontal, vertical) * moveSpeed * Time.deltaTime;
        transform.Translate(BasicMovement);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            sp.color = Color.red;
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            sp.color = Color.green;
        }
    }

}