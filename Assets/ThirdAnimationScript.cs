using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdAnimationScript : MonoBehaviour
{
    [SerializeField]
    private float scaleSpeed = 1.0f;
    void Update()
    {
        transform.localScale += new Vector3(scaleSpeed,scaleSpeed,scaleSpeed) * Time.deltaTime;
    }
}
