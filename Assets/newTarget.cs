using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newTarget : MonoBehaviour
{
    private GameObject _camera;
    private CameraFollow _cameraFollow;

	void Start () {
		_camera = GameObject.FindGameObjectWithTag("MainCamera");
	    _cameraFollow = _camera.GetComponent<CameraFollow>();
	}
	
    void OnCollisionEnter(Collision col)
    {
        if (_cameraFollow.panRight == false)
        {
            _cameraFollow.panRight = true;
        }
        GetComponent<Rigidbody>().useGravity = true;
        Destroy(this);
    }
}
