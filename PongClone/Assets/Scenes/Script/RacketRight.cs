using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RacketRight : MonoBehaviour
{
    public float movementSpeed;

    private void FixedUpdate()
    {
        float v2 = Input.GetAxisRaw("Vertical2");

        GetComponent<Rigidbody2D>().velocity = new Vector2(0, v2) * movementSpeed;

    }
}
