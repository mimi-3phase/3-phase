using UnityEngine;

public class WalkInfinite : MonoBehaviour
{
    public float speed = 5f; // 걷는 속도

    private void Update()
    {
        // 앞으로 이동
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        // 화면 밖으로 나가면 되돌아옴
        /*
        if (transform.position.z > 20f)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -20f);
        }
        */
        
    }
}
