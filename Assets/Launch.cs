using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launch : MonoBehaviour
{
    private Rigidbody _rigidbody;
    private MeshRenderer _meshRenderer;
    private float _launchAmount;

    private bool _launched = false;

	private void Awake ()
	{
	    _rigidbody = GetComponent<Rigidbody>();
	    _meshRenderer = GetComponent<MeshRenderer>();
	    _rigidbody.useGravity = false;
	    _meshRenderer.enabled = false;
	    _launched = false;
	}

	void Update () {
	    if (Input.GetKeyDown(KeyCode.Space) && !_launched)
	    {
	        _launched = true;
	        _rigidbody.useGravity = true;
            _rigidbody.AddForce(new Vector3(200f,150f,0f), ForceMode.Impulse);
	        _meshRenderer.enabled = true;
	    }
	}
}
