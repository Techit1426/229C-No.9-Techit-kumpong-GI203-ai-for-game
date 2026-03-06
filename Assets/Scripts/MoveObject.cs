using UnityEngine;

public class MoveObject : MonoBehaviour
{
    public float speed = 0.5f;   // ความเร็วในการเคลื่อนที่
    private float targetZ = -7f;

    void Update()
    {
        if (transform.position.z > targetZ)
        {
            transform.position += new Vector3(0, 0, -speed * Time.deltaTime);
        }
    }
}