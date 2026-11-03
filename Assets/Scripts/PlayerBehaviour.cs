using NUnit.Framework.Internal.Filters;
using TMPro;
using Unity.VectorGraphics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerBehaviour : MonoBehaviour
{
    public float MovementSpeed = 2.0f;
    [HideInInspector] public bool TouchingGrass = false;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            transform.position = new Vector2(transform.position.x, transform.position.y - (MovementSpeed * Time.deltaTime));
        }
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            transform.position = new Vector2(transform.position.x, transform.position.y + (MovementSpeed * Time.deltaTime));
        }
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            transform.position = new Vector2(transform.position.x - (MovementSpeed * Time.deltaTime), transform.position.y);
        }
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            transform.position = new Vector2(transform.position.x + (MovementSpeed * Time.deltaTime), transform.position.y);
        }
        if (Input.GetKey(KeyCode.B))
        {
            // Load battle scene
            SceneManager.LoadScene(1);
        }
    }

    void OnTriggerEnter2D(Collider2D Other)
    {
        if (Other.CompareTag("TallGrass"))
        {
            TouchingGrass = true;
        }
    }

    void OnTriggerExit2D(Collider2D Other)
    {
        if (Other.CompareTag("TallGrass"))
        {
            TouchingGrass = false;
        }
    }

}
