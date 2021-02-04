using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodMover : MonoBehaviour
{

    private Rigidbody2D body;
    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        body.AddForce(transform.right * 200);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
