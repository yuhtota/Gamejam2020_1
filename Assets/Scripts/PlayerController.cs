using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 20;
    private Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Vector3 s_position = Input.mousePosition;
            s_position.z = 20.0f;
            Vector3 w_position = Camera.main.ScreenToWorldPoint(s_position);
            w_position.y = 0;
            //Vector3 pos = new Vector3(transform.position.x, 0, transform.position.z);
            Vector3 diff = w_position - transform.position;
            if (diff.magnitude < 0.4f)
            {
                rb.velocity = Vector3.zero;
            } else {
                Vector3 nlz = diff.normalized;
                rb.velocity = nlz * speed;
                //transform.rotation = Quaternion.LookRotation(diff);
            }
        }
        if (Input.GetMouseButtonUp(0))
        {
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
        }
    }
}
