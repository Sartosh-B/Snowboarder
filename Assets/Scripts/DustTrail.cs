using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DustTrail : MonoBehaviour
{
    [SerializeField] ParticleSystem dustTrail;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        dustTrail.Play();
    }
    private void OnCollisionExit2D(Collision2D other)
    {
        dustTrail.Stop();
    }

}
