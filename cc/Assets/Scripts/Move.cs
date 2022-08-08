using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public GameObject[] casas;
    public static int indexCasas;

    public bool move;

    // Start is called before the first frame update
    void Start()
    {
        indexCasas -= 6;
        transform.position = new Vector3(casas[0].transform.position.x, 6.109f, casas[0].transform.position.z);
    }

    private void FixedUpdate()
    {
        transform.position = new Vector3(casas[indexCasas].transform.position.x, 6.109f, casas[indexCasas].transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(casas[indexCasas].transform.position.x, 6.109f, casas[indexCasas].transform.position.z);

        if (Input.GetKeyDown(KeyCode.P))
        {
            indexCasas = 0;
        }
    }
}
