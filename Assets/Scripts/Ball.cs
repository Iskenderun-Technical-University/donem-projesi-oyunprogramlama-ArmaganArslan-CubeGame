using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ball : MonoBehaviour
{
    Vector3 direction;

    public float speed;

    public static bool isFall;

    public CubeSpawner cubeSpawnerScript;

    public float addSpeed;

    public void Start()
    {
        direction = Vector3.forward;
    }

    void Update()
    {
        if (transform.position.y <= 0.5f && !isFall)
        {
            isFall = true;
            SceneManager.LoadScene(2);
        }

        if (Input.GetMouseButtonDown(0))
        {
            if (direction.x == 0) 
            {
                direction = Vector3.left;
            }
            else
            {
                direction = Vector3.forward;
            }

            speed = speed += addSpeed * Time.deltaTime;
        }
    }

    private void FixedUpdate()
    {
        Vector3 move = direction * Time.deltaTime * speed;
        transform.position += move;
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Cube") 
        {
            Score.score++;
            collision.gameObject.AddComponent<Rigidbody>();
            cubeSpawnerScript.create_cube();
            StartCoroutine(DeleteCube(collision.gameObject));
        }
    }

    IEnumerator DeleteCube(GameObject deletedCube)
    {
        yield return new WaitForSeconds(3);
        Destroy(deletedCube);
    }
}
