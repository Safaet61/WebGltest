using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    
    void Start()
    {
        transform.position = new Vector3(0, 0, 3);
        transform.localScale = Vector3.one * 2.5f;
        
        Material material = Renderer.material;

        material.color = new Color(.5f, .3f, 1.5f, .5f);
    }
    
    void Update()
    {
        transform.Rotate(0.0f,20.0f * Time.deltaTime, 0.0f);
    }
}
