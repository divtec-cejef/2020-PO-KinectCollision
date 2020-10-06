using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Gère les collisions entre le personnage et les objets présents
public class Collisions : MonoBehaviour   
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter(Collider cube)
    {
        GameObject gameObjectCube = cube.gameObject;
        gameObjectCube.GetComponent<Renderer>().material.color = Color.blue;
    }

    private void OnTriggerExit(Collider cube)
    {
        GameObject gameObjectCube = cube.gameObject;
        gameObjectCube.GetComponent<Renderer>().material.color = Color.green;   
    }
}
