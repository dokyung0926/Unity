using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMove : MonoBehaviour
{
    Transform tr;
    // Start is called before the first frame update
    void Start()
    {
        tr = this.gameObject.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        tr.position += new Vector3(0, 0, 1);
    }
}
