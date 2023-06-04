using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Camera : MonoBehaviour
{
    public Transform ballPosition;
    Vector3 diff;

    void Start()
    {
        diff = transform.position - ballPosition.position;
    }
    
    void LateUpdate()
    {
        if (!Ball.isFall)
        {
            transform.position = ballPosition.position + diff;
        }
    }
}
