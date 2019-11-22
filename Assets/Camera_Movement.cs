using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Movement : MonoBehaviour
{
    public GameObject Bg;
    public Transform target;
    public float smoothTime = 0.3f;
    public float posY, minX, maxX, minY, maxY;
    private Vector3 velocity = Vector3.zero;
    private Vector3 bgp;
    // Use this for initialization
    void Start()
    {
        bgp = Bg.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Bg.transform.position = new Vector3(bgp.x, gameObject.transform.position.y, bgp.z);
        Vector3 targetposition = target.TransformPoint(new Vector3(0, posY, -10));
        Vector3 desiredPosition = Vector3.SmoothDamp(transform.position, target.position, ref velocity, smoothTime);
        transform.position = new Vector3(Mathf.Clamp(desiredPosition.x, minX, maxX), Mathf.Clamp(desiredPosition.y, minY, maxY), desiredPosition.z-1);

    }
}
