using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    public float shell_speed = 7;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float h = 1;
        transform.Translate(new Vector3(0,h,0)*shell_speed*Time.deltaTime);

    }
}
