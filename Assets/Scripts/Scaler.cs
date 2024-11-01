using UnityEngine;

public class Scaler : MonoBehaviour
{
    [SerializeField] private float scaleSpeed = 1.0f;
    private void Update()
    {
        transform.localScale += new Vector3(1,1,1) * scaleSpeed * Time.deltaTime;
    }
}
