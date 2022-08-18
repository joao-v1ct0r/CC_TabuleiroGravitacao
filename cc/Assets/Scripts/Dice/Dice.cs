using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dice : MonoBehaviour
{
    [Header("Imports")]
    public static Rigidbody rb;
    public GameObject collision;

    [Header("Exports")]
    public static Vector3 diceVelocity;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        diceVelocity = rb.velocity;

        if (Input.GetKeyDown(KeyCode.Space))
            Roll();
    }

    private void Roll()
    {
        Move.move = true;

        collision.SetActive(true);
        float dirX = Random.Range(0, 500);
        float dirY = Random.Range(0, 500);
        float dirZ = Random.Range(0, 500);

        transform.position = new Vector3(transform.position.x, transform.position.y + 1.0f, transform.position.z);
        transform.rotation = Quaternion.identity;

        rb.AddForce(transform.up * 250);
        rb.AddTorque(dirX, dirY, dirZ);
    }
}
