using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{

    void FixedUpdate()
    {
        transform.position += Vector3.forward * 7 * Time.fixedDeltaTime;
    }
}
