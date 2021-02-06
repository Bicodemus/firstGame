using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodCollision : MonoBehaviour
{

    private Rigidbody2D other;
    private Rigidbody2D curr;
    // Start is called before the first frame update
    void Start()
    {
        curr = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        other = collision.gameObject.GetComponent<Rigidbody2D>();

        
        
        if (!other.CompareTag("Plate")){
            /*if (other.CompareTag("Floor"))
            {
                Destroy(this.gameObject);
            }*/
            if (!other.CompareTag("onPlate") && !other.CompareTag("Floor"))
            {
               
                other.transform.SetParent(curr.transform);
                other.tag = "onPlate";
                GameManager.Instance.incScore(1);
            }
            
            
        }
    }
}
