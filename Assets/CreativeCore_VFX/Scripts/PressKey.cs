using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressKey : MonoBehaviour
{
    public KeyCode toggleKey = KeyCode.Space;
    private ParticleSystem lightParticle;
    bool isPlaying = true;
    void Start()
    {
        lightParticle = GetComponent<ParticleSystem>();
    }

   
    void Update()
    {
        if (Input.GetKeyDown(toggleKey))
        {
            if(isPlaying)
            {
                lightParticle.Stop();
                isPlaying = false;
            }
            else
            {
                lightParticle.Play();
                isPlaying = true;
            }
        }
    }
}
