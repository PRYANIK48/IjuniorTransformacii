using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FourthAnimationScript : MonoBehaviour
{
    [SerializeField]
    private float rotationSpeed = 1.0f;
    [SerializeField]
    private float scaleSpeed = 1.0f;
    void Update()
    {
        transform.position += transform.forward * Time.deltaTime * 5;
        transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);
        transform.localScale += new Vector3(scaleSpeed, scaleSpeed, scaleSpeed) * Time.deltaTime;
    }
}
