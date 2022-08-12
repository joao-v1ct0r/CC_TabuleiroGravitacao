using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changescene : MonoBehaviour
{
    [SerializeField] string nameScene;

    private void OnCollisionEnter(Collision collision)
    {
        SceneManager.LoadScene("Main");
    }

    public void ChangeScene(string sceneName)
    {
        sceneName = nameScene;
        SceneManager.LoadScene(sceneName);
    }
}
