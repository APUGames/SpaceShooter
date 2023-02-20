using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // This component will handle player action and state

    [SerializeField]
    private int health = 100;

    public float speed = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {
        // Get X-axis movement
        float horizontalInput = Input.GetAxis("Horizontal");

        // Get Y-axis movement
        float verticalInput = Input.GetAxis("Vertical");

        // Deprecated: Using a more performant statement
        // transform.Translate(horizontalInput * speed * Time.deltaTime * Vector3.right);
        // transform.Translate(verticalInput * speed * Time.deltaTime * Vector3.up);

        // Create direction Vector3 object
        Vector3 direction = new Vector3(horizontalInput, verticalInput, 0f);

        // Move the player game object
        transform.Translate(direction * speed * Time.deltaTime);
    }
}
