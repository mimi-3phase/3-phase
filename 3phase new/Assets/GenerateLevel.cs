using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateLevel : MonoBehaviour
{
    public GameObject[] section;
    public int zPos = 10;
    public bool creatingSection = false;
    public int secNum;
    //[SerializeField] private float seconds=1.0f;

    void Update()
    {
        if (creatingSection == false)
        {
            creatingSection = true;
            StartCoroutine(GenerateSection());
        }

        IEnumerator GenerateSection()
        {
            secNum = Random.Range(0, 3);
            Instantiate(section[secNum], new Vector3(0, 0, zPos), Quaternion.identity);
            zPos += 10;
            yield return new WaitForSeconds(3);
            creatingSection = false;
        }
    }
}