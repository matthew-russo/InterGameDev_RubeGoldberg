using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheEnd : MonoBehaviour
{
    public GameObject camera;
    private CameraFollow _cameraFollow;
    public ParticleSystem particleSystem;

    private void Start()
    {
        _cameraFollow = camera.GetComponent<CameraFollow>();
    }

    void OnTriggerEnter()
    {
        _cameraFollow.theEnd = true;
        particleSystem.Play();
    }
}
