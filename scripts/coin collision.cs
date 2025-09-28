using UnityEngine;

public class coincollision : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Level Complete :) ....");

        Time.timeScale = 0f;
    }
}
