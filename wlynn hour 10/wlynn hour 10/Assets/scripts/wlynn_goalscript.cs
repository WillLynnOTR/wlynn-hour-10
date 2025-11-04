using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wlynn_goalscript : MonoBehaviour
{

    public bool isSolved = false;
    public GameObject flag;


    private void Start()
    {

    }
    void OnTriggerEnter(Collider collider)
    {

        GameObject collidedWith = collider.gameObject; if (collidedWith.tag == gameObject.tag)

        {
           
            isSolved = true; GetComponent<Light>().enabled = false; 
            
            Destroy(collidedWith);
            Destroy(flag);
            

        }
    }
}