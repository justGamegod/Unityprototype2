using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlPlayer : MonoBehaviour
{
    private float horizonInput;
    private float speed = 15.0f;
    private float xRange = 15.0f;

    public GameObject projectilePrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if obj position is less than 10
        if (transform.position.x < -xRange)
        {
            //set position to a new value
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        if(transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        horizonInput = Input.GetAxis("Horizontal");
        transform.Translate(horizonInput * speed * Time.deltaTime * Vector3.right);

        //if spaceBar key is pressed down
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Instanciate creates a copy of prefabs / game object
            Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }
    }
}
