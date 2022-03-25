using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCubeHeight : MonoBehaviour
{
    public static MainCubeHeight instance;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

    // MainCube'un pozisyonunu yükseltir
    public void IncreaseMainCubeY()
    {
        transform.position = transform.position + Vector3.up;
    }


    // MainCube'un pozisyonunu azaltýr
    public void ReduceMainCubeY()
    {
        transform.position = transform.position + Vector3.down;
    }
}
