using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class blueController : MonoBehaviour {

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
            case 9:
                Destroy(gameObject);
                scoreskript.scoreUpdate();
                gamemanager.CompleteLevel();
                break;
            default:
                Destroy(gameObject);
                scoreskript.resetScore();
                gamemanager.EndGame();
                break;
        }
    }

}
