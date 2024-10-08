using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CrashDetector : MonoBehaviour

{
    [SerializeField] float delayFinish = 0.5f;
    [SerializeField] ParticleSystem crashEffect;

    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == "Ground")
        {
            crashEffect.Play();
            Invoke("ReloadScene", delayFinish);
        }

        //  if (other.tag == "Rock")
        // {
        //     crashEffect.Play();
        //     Invoke("ReloadScene", delayFinish);
        // }
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
