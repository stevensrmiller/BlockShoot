using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockPuncher : MonoBehaviour
{
    public Counter counter;

    // Start is called before the first frame update
    void Start()
    {
        counter.AddOne();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < 0)
        {
            counter.SubOne();
            Destroy(gameObject);
        }
    }
}
