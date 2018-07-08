using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public Rigidbody2D rb;
    public bool isJumping = false;
    public float jumpforce = 1f;
    public Vector2 force;

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKey(KeyCode.Space) && !isJumping)
        {
            force.Set(0f, jumpforce);
            rb.AddForce(force, ForceMode2D.Impulse);
            isJumping = true;
        }
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "ground")
        {
            isJumping = false;
        }
    }
}
