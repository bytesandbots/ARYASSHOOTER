using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class infbullet : MonoBehaviour
{
    public float bullet_speed = 7;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float h = 1;
        transform.Translate(new Vector3(0, h, 0) * bullet_speed * Time.deltaTime);
    }
}