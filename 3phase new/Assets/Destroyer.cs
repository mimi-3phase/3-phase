using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    public string parentName;
    [SerializeField] private float seconds = 5.0f;

    void Start()
    {
        parentName = transform.name;//get the name of the obect
        StartCoroutine(DestroyClone());//ÄÚ·çÆ¾....
    }

    IEnumerator DestroyClone()
    {
        yield return new WaitForSeconds(seconds);
        if (parentName == "Mark(Clone)")
        {
            Destroy(gameObject);
        }
    }
}
