using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public Transform shell_pos;
    public GameObject shell;
    public float shell_frequency = .1f;
    private float c_time;

    void Start()
    {
    }

  
    void Update()
    {
        if (c_time < shell_frequency)
        {
            c_time += Time.deltaTime;
        }
        else
        {
            if (Input.GetKey(KeyCode.Space))
            {
                GameObject new_shell = Instantiate(shell, shell_pos.position, shell_pos.rotation);

                c_time = 0;
            }
        }
    }
}
