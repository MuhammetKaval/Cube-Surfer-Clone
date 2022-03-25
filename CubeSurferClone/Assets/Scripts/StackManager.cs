using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StackManager : MonoBehaviour
{
    public static StackManager instance;

    // Toplanan kuplerin nereye yerleþtirileceðinin bilgisini tutar
    [SerializeField] public float distanceBetweenObjects;
    //[SerializeField] public float distanceBetweenObjects { get; set; }

    [SerializeField] private Transform prevObject;
    [SerializeField] private Transform parent;


    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }


    void Start()
    {
        //distanceBetweenObjects = prevObject.localScale.y;
        distanceBetweenObjects = 0;
    }

    public void Collect(GameObject collectedObject, bool needTag = false, string tag = null, bool downOrUp = true)
    {
        if (needTag)
        {
            collectedObject.tag = tag;
        }

        // Modifiye
        distanceBetweenObjects++;

        collectedObject.transform.parent = parent;
        Vector3 desPos = prevObject.localPosition;
        desPos.y += downOrUp ? distanceBetweenObjects : -distanceBetweenObjects;

        collectedObject.transform.localPosition = desPos;

        


        //prevObject = collectedObject.transform;

        
    }

    

}
