using System.Collections;
using System.Collections.Generic;
using System.Security.Permissions;
using UnityEngine;

//Gère les collisions entre le personnage et les objets présents
public class Collisions : MonoBehaviour   
{

    public Material rouge;
    public Material bleu;

    private void OnTriggerEnter(Collider cube)
    {
        GameObject gameObjectCube = cube.gameObject;
        gameObjectCube.GetComponent<Renderer>().material = rouge;
    }

    private void OnTriggerExit(Collider cube)
    {
        GameObject gameObjectCube = cube.gameObject;
        gameObjectCube.GetComponent<Renderer>().material = bleu;
    }
}
