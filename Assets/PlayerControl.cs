using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour

{
    private Rigidbody2D rd2D;
    private Vector2 move;
    public float moveSpeed = 100f;

    // Start is called before the first frame update
    void Start()
    {
        rd2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        move = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
    }

    private void FixedUpdate()
    {
        rd2D.AddForce(move * moveSpeed);

    }

}
