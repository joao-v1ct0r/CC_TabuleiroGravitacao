using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carta : MonoBehaviour
{
    public Animator anim;
    // Start is called before the first frame update
    public void False()
    {
        Move.indexCasas = 0;
        anim.SetInteger("Animator", 1);
    }

    // Update is called once per frame
    public void True()
    {
        Move.indexCasas += 10;
        anim.SetInteger("Animator", 1);
    }
}
