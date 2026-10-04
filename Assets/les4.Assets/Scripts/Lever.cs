using UnityEngine;

public class Lever : MonoBehaviour
{
    public GameObject platform;
    private bool isActivated = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isActivated = !isActivated;
            platform.SetActive(isActivated);
            transform.Rotate(0, 0, isActivated ? 45f : -45f);
            Debug.Log("Рычаг переключен");
        }
    }
}
