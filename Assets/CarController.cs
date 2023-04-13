using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{

    float speed = 0;

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            if (this.speed == 0)
            {
                this.speed += 0.2f;

                GetComponent<AudioSource>().Play();
            }

            this.speed *= 1.02f;
        }

        transform.Translate(this.speed, 0, 0);


        this.speed *= 0.983f;
    }

    public float GetSpeed()
    {
        return this.speed;
   }
}
