using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    [Header("SceneLoaderConfig")]
    [SerializeField] private GameObject loadingOverlay;
    
    //fadetime
    [Range(0.01f, 3.0f)]
    [SerializeField]    
    private float fadeTime = 0.5f;


    //estancia estatica da script
    public static SceneLoader instance { get; private set; }
    //                   pode ser recebida mas nao modificada

    //so existir 1 instancia no mundo
    private void Awake()
    {
        if (instance == null)
        {
            //se ela nao foi setada ela mesma vai ser a instancia do jogo
            instance = this;
            //nao pode ser destruido ao mudar de cena
            DontDestroyOnLoad(gameObject);
        }
        //se ja foi setada ela se destroi
        else
        {
            Destroy(gameObject);
        }
    }

    public void LoadSceneAsync(string sceneName)
    {
        sceneName = "Main";
        StartCoroutine(PerformLoadSceneAsync(sceneName));
    }

    private IEnumerator PerformLoadSceneAsync(string sceneName)
    {
        //fade in
        yield return StartCoroutine(FadeIn());

        var operation = SceneManager.LoadSceneAsync(sceneName);
        while(operation.isDone == false)
        {
            yield return null;
        }

        //fade out
        yield return StartCoroutine(FadeIn());
    }

    private IEnumerator FadeIn()
    {
        loadingOverlay.SetActive(active)
        yield return null;

        /* depois voltar
float start = 0;
float end = 1;

// Delta S / Delta T (end - start)/fade time


float speed = (end - start) / fadeTime;

loadingOverlay.alpha = start;

while(loadingOverlay.alpha < end)
{
    loadingOverlay.alpha += speed * Time.deltaTime;
    yield return null;
}

loadingOverlay.alpha = end;

*/
    }

    private IEnumerator FadeOut()
    {
        float start = 1;
        float end = 0;

        // Delta S / Delta T (end - start)/fade time

        float speed = (end - start) / fadeTime;

        loadingOverlay.alpha = start;

        while (loadingOverlay.alpha > end)
        {
            loadingOverlay.alpha += speed * Time.deltaTime;
            yield return null;
        }
        loadingOverlay.alpha = end;
    }
}
