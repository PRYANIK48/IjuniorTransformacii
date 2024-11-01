using UnityEngine;

public class Scaler : MonoBehaviour
{
    [SerializeField] private float scaleSpeed = 1.0f;

    private void Update()
    {
        transform.localScale += Vector3.one * scaleSpeed * Time.deltaTime;
    }
}
