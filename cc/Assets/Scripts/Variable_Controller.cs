using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variable_Controller : MonoBehaviour
{
    public float _delay;
    public static float delay;

    private void Update()
    {
        delay = _delay;
    }
}
