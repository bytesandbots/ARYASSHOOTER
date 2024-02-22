using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfAi : MonoBehaviour
{
    public GameObject target;
    public float rotSpeed = 150;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Collider2D[] victims = Physics2D.OverlapCircleAll(transform.position, 5);
        float min = 10000000;
        foreach(Collider2D enemy in victims)
        {
            float distance = Vector3.Distance(transform.position, enemy.transform.position);
            if (min > distance)
            {
                min = distance;
                target = enemy.gameObject;
            }
        }

        if (target != null)
        {
            Vector3 dir = target.transform.position - transform.position;
            dir.Normalize();

            float zAngle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg - 90;

            Quaternion desiredRot = Quaternion.Euler(0, 0, zAngle);

            transform.rotation = Quaternion.RotateTowards(transform.rotation, desiredRot, rotSpeed * Time.deltaTime);

            GetComponent<InfShooting>().can_shoot = true;
        }
    }
}
