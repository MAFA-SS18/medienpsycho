using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    bool gameended = false;
    public float delay = 0.5f;
    public GameObject CompleteLevelUI;
    public int stage = 0;
    public int loop = 0;
    public GameObject[] colors;
    public Quaternion rotation = Quaternion.Euler(0,0,0);
    public GameObject blueSign;
    public GameObject redSign;
    public GameObject plus;
    public GameObject yellowSign;
    public GameObject greenSign;
    public GameObject redSign2;
    public GameObject yellowSign2;
    public GameObject yellowSign3;
    public GameObject blueSign2;

    private void Start()
    {
        StartCoroutine(spawn());
    }

    public void EndGame()
    {
        if (gameended == false)
        {
            gameended = true;
            Invoke("restart", delay);
        }
    }

    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void CompleteLevel()
    {

       // CompleteLevelUI.SetActive(true);

    }

    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public IEnumerator spawn()
    {
        while (loop == 0) {
            int prefeb_num = Random.Range(0, 6);
            yield return new WaitForSeconds(1.7f);
            Instantiate(colors[prefeb_num], new Vector3(5, -3, 0), rotation); }
    }

    public void level01()
    {
        stage += 1;
        redSign.GetComponent<Renderer>().enabled = false;
        greenSign.GetComponent<Renderer>().enabled = true;
    }

    public void level02()
    {
        stage += 1;
        greenSign.GetComponent<Renderer>().enabled = false;
        yellowSign.GetComponent<Renderer>().enabled = true;
        plus.GetComponent<Renderer>().enabled = true;
        redSign2.GetComponent<Renderer>().enabled = true;
    }

    public void level03()
    {
        stage += 1;
        blueSign.GetComponent<Renderer>().enabled = true;
        yellowSign.GetComponent<Renderer>().enabled = false;
    }

    public void level04()
    {
        stage += 1;
        blueSign.GetComponent<Renderer>().enabled = false;
        yellowSign2.GetComponent<Renderer>().enabled = true;
        plus.GetComponent<Renderer>().enabled = false;
        redSign2.GetComponent<Renderer>().enabled = false;
    }

    public void level05()
    {
        stage += 1;
        yellowSign2.GetComponent<Renderer>().enabled = false;
        plus.GetComponent<Renderer>().enabled = true;
        yellowSign3.GetComponent<Renderer>().enabled = true;
        blueSign.GetComponent<Renderer>().enabled = true;
    }

    public void level06()
    {
        stage += 1;
        blueSign.GetComponent<Renderer>().enabled = false;
        yellowSign.GetComponent<Renderer>().enabled = true;
        redSign2.GetComponent<Renderer>().enabled = true;
        yellowSign3.GetComponent<Renderer>().enabled = false;
    }

    public void level07()
    {
        stage += 1;
        yellowSign.GetComponent<Renderer>().enabled = false;
        redSign2.GetComponent<Renderer>().enabled = false;
        plus.GetComponent<Renderer>().enabled = false;
        greenSign.GetComponent<Renderer>().enabled = true;
    }

    public void level08()
    {
        stage += 1;
        greenSign.GetComponent<Renderer>().enabled = false;
        plus.GetComponent<Renderer>().enabled = true;
        redSign2.GetComponent<Renderer>().enabled = true;
        blueSign.GetComponent<Renderer>().enabled = true;
    }

    public void level09()
    {
        stage += 1;
        plus.GetComponent<Renderer>().enabled = false;
        redSign2.GetComponent<Renderer>().enabled = false;
        blueSign.GetComponent<Renderer>().enabled = false;
        blueSign2.GetComponent<Renderer>().enabled = true;
    }
}