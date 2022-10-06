using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Line : MonoBehaviour
{
    public float moveSpeed;
    float xDirection;
    // Start is called before the first frame update
    void Start()
    {
        moveSpeed = 40;
    }

    // Update is called once per frame
    void Update()
    {
        xDirection = Input.GetAxisRaw("Horizontal");
        if ((xDirection < 0 && transform.position.x <= -9.5) || (xDirection > 0 && transform.position.x >= 9.5))
        {
            return;
        }
        float moveStep = moveSpeed * xDirection * Time.deltaTime;
        transform.position += new Vector3(moveStep, 0, 0);
    }
}
