using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnStackTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Block")
        {
            other.gameObject.GetComponent<BoxCollider>().enabled = false;
            gameObject.GetComponent<BoxCollider>().enabled = false;

            transform.parent = null;

            // birakilacak olan kupun engelin tam onunde birakilmasini saglar
            transform.position = other.transform.position + new Vector3(transform.position.x,0,-1);

            // Modifiye
            // toplanan kuplerinin nereye yerlestirilecein
            StackManager.instance.distanceBetweenObjects--;

            MainCubeHeight.instance.ReduceMainCubeY();

            
            
            
        }
    }
}
