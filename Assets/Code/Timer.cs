using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public Counter counter;

    TextMesh textMesh;

    float t0;
    bool isRunning;

    // Start is called before the first frame update
    void Start()
    {
        counter.Over += Over;

        t0 = Time.time;

        textMesh = GetComponent<TextMesh>();

        isRunning = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (isRunning)
        {
            float t1 = Time.time - t0;

            string s = string.Format("{0,5:F1}", t1);

            textMesh.text = s;
        }
    }

    void Over()
    {
        isRunning = false;

        textMesh.text += "\n\n\n\n\n       space to play again, esc to quit.";
    }
}
