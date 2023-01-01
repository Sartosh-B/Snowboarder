using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class CrushDetector : MonoBehaviour
{
    [SerializeField] ParticleSystem crushEffect;
    [SerializeField] AudioClip crashSFX;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Ground")
        {
            FindObjectOfType<PlayerController>().DisableControls();
            GetComponent<AudioSource>().PlayOneShot(crashSFX);
            Debug.Log("Groudn!");
            crushEffect.Play();
            //SceneManager.LoadScene(0);
        }
    }

}
