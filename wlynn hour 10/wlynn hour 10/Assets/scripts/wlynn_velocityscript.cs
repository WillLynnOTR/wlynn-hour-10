using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class wlynn_velocityscript : MonoBehaviour
{
    // Start is called before the first frame update

    public Rigidbody rb;
    public float startSpeed = 5;
    public int randomRotate = 0;
    void Start()
    {
        randomRotate = Random.Range(1, 21);

        this.transform.Rotate(randomRotate, 0, 0);
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(startSpeed, 0, startSpeed);
        
    }

    // Update is called once per frame
    void Update()
    {

    }
}
