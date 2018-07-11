using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndController : MonoBehaviour
{

    public Rigidbody2D rb;
    public GameManager gamemanager;

    // Update is called once per frame
    void Update()
    {

        rb.AddForce(new Vector2(-5, 0));

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        gamemanager.CompleteLevel();
    }
}
