using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardMovement : MonoBehaviour
{
    
    private Vector3 touchStart;
    private Vector3 scale;
    public float amplification = 10f;
    public float zoomMin = 0.5f;
    public float zoomMax = 8f;

    public GameObject properties;

    void Start()
    {
        scale = this.GetComponent<RectTransform>().localScale;
    }

    void Update()
    {
        
        if(properties.activeInHierarchy == false)
        {
            if(Input.touchCount == 2)
            {
                Touch touchZero = Input.GetTouch(0);
                Touch touchOne = Input.GetTouch(1);

                Vector2 zeroprevPos = touchZero.position - touchZero.deltaPosition;
                Vector2 oneprevPos = touchOne.position - touchOne.deltaPosition;

                float prevMag = (zeroprevPos-oneprevPos).magnitude;
                float currMag = (touchZero.position-touchOne.position).magnitude;

                float diff = currMag-prevMag;

                Zoom(diff*0.005f);
            }

            Zoom(Input.GetAxis("Mouse ScrollWheel"));
        }

    }

    void Zoom(float increment)
    {
        float x = scale.x+increment;
        float y = scale.y+increment;
        scale = new Vector3(Mathf.Clamp(x,zoomMin,zoomMax),Mathf.Clamp(y,zoomMin,zoomMax),scale.z);
        this.GetComponent<RectTransform>().localScale = scale;
    }


}
