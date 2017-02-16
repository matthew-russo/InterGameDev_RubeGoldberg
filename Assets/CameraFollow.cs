using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject target;
    public GameObject ball;
    public GameObject ball2;
    public bool panRight = false;
    private bool started = false;
    public bool theEnd = false;

	void Start ()
	{
        target = ball;
	}
	
	void Update ()
	{
	    if (panRight)
	    {
	        target = ball2;
	        if (!started)
	        {
                StartCoroutine(PanRight());
            }
        }
	    else
	    {
	        if (theEnd)
	        {
	            //nada
	        }
	        else
	        {
                transform.position = new Vector3(transform.position.x, target.transform.position.y, transform.position.z);
                transform.LookAt(target.transform);
            }
        }
	}

    private IEnumerator PanRight()
    {
        started = true;
        float iterations = 380;
        while (iterations > 0)
        {
            transform.Rotate(0f, 0.093f, 0f);
            transform.Translate(0f,-0.035f, 0f);
            iterations--;
            yield return new WaitForSecondsRealtime(.01f);
        }

        panRight = false;
        yield return new WaitForEndOfFrame();
    }
}
