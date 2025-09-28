using UnityEngine;
public class PlayerController : MonoBehaviour
{
    [SerializeField] float speed = 10f, boostSpeed = 15f;
    [SerializeField] float minX = -27f, maxX = 27f, minZ = -23f, maxZ = 23f;

    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        float s = Input.GetKey(KeyCode.LeftShift) ? boostSpeed : speed;

        transform.Translate(new Vector3(h, 0, v) * s * Time.deltaTime, Space.World);

        float clampedX = Mathf.Clamp(transform.position.x, minX, maxX);
        float clampedZ = Mathf.Clamp(transform.position.z, minZ, maxZ);
        transform.position = new Vector3(clampedX, transform.position.y, clampedZ);
    }
}
