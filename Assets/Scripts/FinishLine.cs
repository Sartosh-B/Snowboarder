using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishLine : MonoBehaviour
{
    [SerializeField] float restarDelay = 2f;
    [SerializeField] ParticleSystem finishEfect;
    

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Player")
        {
            
            Debug.Log("Finish");
            Invoke("ReloadScene", restarDelay);
            finishEfect.Play();
            
        }
    }
    void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
}
