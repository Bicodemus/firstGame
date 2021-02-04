using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaughtFood : MonoBehaviour
{
    private Rigidbody2D plate;
    private GameObject food;

    // Start is called before the first frame update
    void Start()
    {
        plate = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        food = collision.gameObject;
        food.GetComponent<Rigidbody2D>().isKinematic = true;
        food.transform.SetParent(plate.transform);
        food.tag = "onPlate";
        Debug.Log("hit");
        Debug.Log("hit2");
    }
}
