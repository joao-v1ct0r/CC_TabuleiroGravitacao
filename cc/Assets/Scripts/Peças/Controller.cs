using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Controller : MonoBehaviour
{
    void Update()
    {
        if(Move.indexCasas == 2)
        {
            Move.indexCasas++;
            SceneManager.LoadScene("isaac newton");
        }
    }
}
