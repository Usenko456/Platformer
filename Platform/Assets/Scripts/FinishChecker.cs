using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class FinishChecker : MonoBehaviour
{
    public GameObject player;
    private float startAlpha = 0f;
    private float endAlpha = 1f;
    private float time = 3/2;
    public UnityEvent Myevents;
    [SerializeField] public string scene;
    [SerializeField] private Animator anim;
    public Image dimPanel; 
    public float fadeDuration = 1f; 
    int levelnumber;

    private void Start()
    {
        levelnumber = int.Parse(SceneManager.GetActiveScene().name.Substring(5));
        if (dimPanel != null)
        {
            dimPanel.enabled = false;
            SetAlpha(0);
        }
    }
    private void OnTriggerEnter2D(Collider2D other2D)
    {
        if (other2D.CompareTag("Player"))
        {
            dimPanel.enabled = true;
            StartCoroutine(LoadSceneWithDelay());
            if (ButtonActivasion.numberofunlockedlevels == levelnumber)
            {
                ButtonActivasion.numberofunlockedlevels = levelnumber + 1 ;
            }
            
        }
    }

    private IEnumerator LoadSceneWithDelay()
    {
        Myevents.Invoke();
        yield return new WaitForSeconds(time);
        float elapsedTime = 0f;
        while (elapsedTime < fadeDuration)
        {
            elapsedTime += Time.deltaTime;
            float newAlpha = Mathf.Lerp(startAlpha, endAlpha, elapsedTime / fadeDuration);
            SetAlpha(newAlpha);
            yield return null;

        }
        SetAlpha(endAlpha);
        SceneManager.LoadScene(scene);
    }
    private void SetAlpha(float alpha)
    {
        Color color = dimPanel.color;
        color.a = alpha;
        dimPanel.color = color;
    } 
}



