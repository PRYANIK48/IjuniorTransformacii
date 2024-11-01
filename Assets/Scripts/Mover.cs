using UnityEngine;

public class Mover : MonoBehaviour
{
    private void Update()
    {
        transform.position += transform.forward * Time.deltaTime;
    }
}
