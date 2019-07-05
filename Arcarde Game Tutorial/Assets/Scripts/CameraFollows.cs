using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollows : MonoBehaviour
{
    public GameObject target;
    

    private Transform t;

    private void Awake()
    {
        var cam = GetComponent<Camera>();
        
    }
    // Start is called before the first frame update
    void Start()
    {
        t = target.transform;
    }

    // Update is called once per frame
    void Update()
    {
        if(target != null)
        {
            transform.position = new Vector3(t.position.x, t.position.y, t.position.z -1);
        }
    }
}
