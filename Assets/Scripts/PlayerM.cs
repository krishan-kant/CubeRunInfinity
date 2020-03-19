using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerM : MonoBehaviour
{
    public float speed = 240f;
    public float mapWidth = 7f;
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();  
    }

    private void FixedUpdate()
    {
        if (Input.GetKeyDown("escape"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        float x1 = Input.GetAxis("Horizontal") * Time.fixedDeltaTime * speed;
        //float x1 = Input.acceleration.x * Time.fixedDeltaTime * speed;
        Vector3 newPosition = rb.position + Vector3.right * x1;
        newPosition.x = Mathf.Clamp(newPosition.x, -mapWidth, mapWidth);
        rb.MovePosition(newPosition);

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManagerInf>().EndGame();
        }
    }

    private void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.name != "Ground")
        {
            FindObjectOfType<GameManagerInf>().EndGame();
        }
    }
}
