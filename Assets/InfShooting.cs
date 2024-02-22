using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfShooting : MonoBehaviour
{
    public Transform bullet_pos;
    public GameObject bullet;
    public float bullet_frequency = .1f;
    private float c_time;
    public bool can_shoot;

    void Start()
    {
    }


    void Update()
    {
        if (c_time < bullet_frequency)
        {
            c_time += Time.deltaTime;
        }
        else
        {
            if (can_shoot)
            {
                GameObject new_bullet= Instantiate(bullet, bullet_pos.position, bullet_pos.rotation);

                c_time = 0;
            }
            }
        }
    }
}
