using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyItem : MonoBehaviour
{
    public GameObject targetPosition;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void ItemDestroyer()
    {
        if(transform.position==targetPosition.transform.position)
        {
            Debug.Log("I'll destroy");
            Destroy(gameObject);
        }

        
    }
}