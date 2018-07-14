using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class greenController : MonoBehaviour {

    public Rigidbody2D rb;
    public float delay = 0.5f;
    public GameManager gamemanager;
    public GameObject Score;
    public score scoreskript;

    private void Start()
    {
        gamemanager = GameObject.Find("GameManager").GetComponent<GameManager>();
        Score = GameObject.Find("Score");
        scoreskript = (score)Score.GetComponent(typeof(score));
    }

    // Update is called once per frame
    void Update () {

        rb.AddForce(new Vector2(-4, 0));

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        switch (gamemanager.stage)
        {
            case 1:
                Destroy(gameObject);
                scoreskript.scoreUpdate();
                gamemanager.level02();
                break;
            case 5:
                Destroy(gameObject);
                scoreskript.scoreUpdate();
                gamemanager.level06();
                break;
            case 7:
                Destroy(gameObject);
                scoreskript.scoreUpdate();
                gamemanager.level08();
                break;
            default:
                Destroy(gameObject);
                scoreskript.resetScore();
                gamemanager.EndGame();
                break;
        }
    }

}
