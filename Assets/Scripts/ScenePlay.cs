using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScenePlay : MonoBehaviour
{
    public GameObject cube;
    public GameObject sphere;
    public GameObject cylinder;
    public bool isCube,isSphere,isCylinder; 
    float angle = 0f;

    void Update()
    {        
        if (isCube)
            cube.GetComponent<Transform>().transform.position += new Vector3(0, 0, 2) * Time.deltaTime;
        if (isSphere)
            sphere.GetComponent<Transform>().transform.localScale += new Vector3(1.5f, 1.5f, 1.5f) * Time.deltaTime;
        if (isCylinder)
        {            
            angle += -5f * Time.deltaTime;
            if (angle % 360 == 0)
                angle = 0;
            cylinder.GetComponent<Transform>().transform.rotation = Quaternion.Euler(angle, 0f, 0f);
        }
        
    }
}
