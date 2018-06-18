using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class yellowController : MonoBehaviour {

    public Rigidbody2D rb;
    public float delay = 0.5f;
    public GameManager gamemanager;

    private void Start()
    {
        gamemanager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update () {

        rb.AddForce(new Vector2(-5, 0));

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        switch (gamemanager.stage)
        {
            case 4:
                gamemanager.level05();
                break;
            default:
                gamemanager.EndGame();
                break;
        }
    }

}
