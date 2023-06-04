using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    public GameObject last_cube;
    
    void Start()
    {
        for (int i = 0; i < 25; i++)
        {
            create_cube();
        }
    }

    public void create_cube()
    {
        Vector3 direction;

        if (Random.Range(0, 2) == 0)
        {
            direction = Vector3.left;
        }

        else
        {
            direction = Vector3.forward;
        }

        last_cube = Instantiate(last_cube, last_cube.transform.position + direction, last_cube.transform.rotation);
    }
}
