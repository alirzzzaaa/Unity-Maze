using UnityEngine;

public class CoinRotate : MonoBehaviour
{
    public float rotateSpeed = 180f; // degrees per second

    void Update()
    {
        transform.Rotate(0, rotateSpeed * Time.deltaTime, 0, Space.World);
    }
}
