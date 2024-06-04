using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lifetime : MonoBehaviour
{
    public float Life = 5;
    public float PopRate = .01f;

    AudioSource audioSource;
    bool isDying;

    Vector3 size;

    // Start is called before the first frame update
    void Start()
    {
        size = Vector3.one;
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Life < 0)
        {
            size.x += PopRate;
            size.y += PopRate;
            size.z += PopRate;

            if (size.x > 1 + 3 * PopRate)
            {
                Object.Destroy(gameObject);
            }
            else
            {
                if (!isDying)
                {
                    isDying = true;

                    if (transform.position.y > 0)
                    {
                        audioSource.Play(0);
                    }
                }

                transform.localScale = size;
            }
        }

        Life -= Time.deltaTime;
    }
}
