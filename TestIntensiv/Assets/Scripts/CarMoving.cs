using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMoving : MonoBehaviour
{
    public float speed = 15f;

    void Update()
    {
        transform.localPosition += transform.forward * speed * Time.deltaTime;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag.Equals("stop"))
        {
            Destroy(transform.gameObject);
        }
    }
}
