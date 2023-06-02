
using UnityEngine;

public class MoveToTarget : MonoBehaviour
{
    public GameObject targetPosition;

    void Update()
    {
        transform.position = Vector3.MoveTowards(gameObject.transform.position, targetPosition.transform.position, 0.005f);
    }
}
