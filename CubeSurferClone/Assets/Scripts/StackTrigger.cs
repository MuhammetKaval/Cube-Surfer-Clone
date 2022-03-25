using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StackTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Collectable")
        {
            StackManager.instance.Collect(other.gameObject, true, "Collected", false);

            // MainCube'un pozisyonunu ayaralar
            MainCubeHeight.instance.IncreaseMainCubeY();
        }
    }
}
