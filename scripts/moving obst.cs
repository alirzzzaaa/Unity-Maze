using UnityEngine;
using UnityEngine.UI;

public class ObstacleMovement : MonoBehaviour
{
    public float speed = 4f;
    private float minX = -2f;
    private float maxX = 24f;
    private Vector3 direction = Vector3.right;
   
    void Update()
    {
        transform.position += direction * speed * Time.deltaTime;

        if (transform.position.x >= maxX)
            direction = Vector3.left;
        else if (transform.position.x <= minX)
            direction = Vector3.right;
    }

   
}
