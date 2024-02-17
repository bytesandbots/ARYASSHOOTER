using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        Vector3 Direction = new Vector3(0, 0, -h);
        transform.Rotate(Direction * speed * Time.deltaTime);
        Vector3 Dummy = transform.eulerAngles;
        Debug.Log(Dummy.z);
        if (Dummy.z >= 250) {
            Dummy.z -= 360;
            Dummy.z = Mathf.Clamp(Dummy.z, -60, 60);
            Dummy.z += 360;
        }
        else
        {
            Dummy.z = Mathf.Clamp(Dummy.z, -60, 60);
        }
        
        transform.eulerAngles = Dummy;

    }
}
