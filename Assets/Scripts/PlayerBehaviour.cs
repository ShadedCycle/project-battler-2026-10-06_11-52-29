using NUnit.Framework.Internal.Filters;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    public float MovementSpeed = 2.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            transform.position = new Vector2(transform.position.x, transform.position.y - MovementSpeed);
        }
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            transform.position = new Vector2(transform.position.x, transform.position.y + MovementSpeed);
        }
        if (Input.GetKey(KeyCode.LeftArrow)  || Input.GetKey(KeyCode.A))
        {
            transform.position = new Vector2(transform.position.x - MovementSpeed, transform.position.y);
        }
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            transform.position = new Vector2(transform.position.x + MovementSpeed, transform.position.y);
        }
    }
}
