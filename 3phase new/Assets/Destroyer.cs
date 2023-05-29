using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    public string parentName;

    void Update()
    {
        parentName = transform.name;

    }

    IEnumerator DestroyClone()
    {
        yield return new WaitForSeconds(2);
        if (parentName == "Section(Clone)")
        {
            Destroy(gameObject);
        }
    }
}
