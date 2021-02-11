using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("z"))
            transform.Translate(Vector3.forward);
        if (Input.GetKeyDown("s"))
            transform.Translate(-Vector3.forward);
        if (Input.GetKeyDown("q"))
            transform.Translate(Vector3.left);
        if (Input.GetKeyDown("d"))
            transform.Translate(Vector3.right);
    }
}
