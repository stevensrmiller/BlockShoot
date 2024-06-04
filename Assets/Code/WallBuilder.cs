using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WallBuilder : MonoBehaviour
{
    public GameObject Block;
    public GameObject Ball;
    public GameObject ShotClock;
    public Counter counter;
    public float ShotDelay = .5f;
    public GameObject StartButton;

    public float Power = 50;
    public int Rows = 3;
    public int Length = 7;
    public int Layers = 1;

    float shotCountdown = 0;

    bool isDone;

    // Start is called before the first frame update
    void Start()
    {
        isDone = false;
        StartButton.SetActive(false);

        Instantiate(Block, new Vector3(0, .5f), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        if (!isDone && shotCountdown == 0 && Input.GetButtonDown("Fire1"))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            GameObject ball = Instantiate(Ball, ray.origin, Quaternion.identity);

            Rigidbody rb = ball.GetComponent<Rigidbody>();

            rb.AddForce(ray.direction * Power, ForceMode.Impulse);

            shotCountdown = ShotDelay + Time.deltaTime;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            NewGame();
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }

        shotCountdown -= Time.deltaTime;

        shotCountdown = shotCountdown < 0 ? 0 : shotCountdown;

        ShotClock.transform.localScale = new Vector3(17 * shotCountdown / ShotDelay, 1, 1);
    }

    public void NewGame()
    {
        SceneManager.LoadScene("SampleScene");
        counter.ReStart();
    }

    public void Done()
    {
        isDone = true;
        StartButton.SetActive(true);
    }
}
