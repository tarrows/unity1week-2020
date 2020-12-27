using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotate : MonoBehaviour
{
    private Plane plane = new Plane();
    private float distance = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, Input.GetAxis("Horizontal"), 0);

        //  var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        // plane.SetNormalAndPosition(Vector3.up, transform.localPosition);

        // if (plane.Raycast(ray, out distance))
        // {
        //     var lookPoint = ray.GetPoint(distance);
        //     transform.LookAt(lookPoint);

        GameObject cam = Camera.main.transform.parent.gameObject;
        //    CameraTarget.transform.LookAt(lookPoint);
        // }
        
        cam.transform.Rotate(Input.GetAxis("Vertical2"), 0, 0);
    }
}
