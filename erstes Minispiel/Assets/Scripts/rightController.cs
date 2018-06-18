using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class rightController : MonoBehaviour {

    public Rigidbody2D rb;

    // Update is called once per frame
    void Update () {

        rb.AddForce(new Vector2(-5,0));
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
