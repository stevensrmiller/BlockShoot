using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public Counter counter;
    public GameObject field;

    WallBuilder wallBuilder;

    TextMesh textMesh;

    // Start is called before the first frame update
    void Start()
    {
        counter.Over += Over;
        textMesh = GetComponent<TextMesh>();

        textMesh.text = "";

        wallBuilder = field.GetComponent<WallBuilder>();
    }

    private void Over()
    {
        textMesh.text = "Good Job!";
        wallBuilder.Done();
    }
}
