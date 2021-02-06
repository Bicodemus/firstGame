using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowFood : MonoBehaviour
{

    public GameObject food;
    private GameObject pancake;
    private GameObject chef;
    private Vector2 vector;
    // Start is called before the first frame update
    void Start()
    {
        chef = this.gameObject;
        StartCoroutine("throwing");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator throwing()
    {
        yield return new WaitForSeconds(2f);
        for (; ; )
        {

            
            if (chef.CompareTag("Chef1"))
            {
                vector = new Vector2(-8f, 4.5f);
                pancake = Instantiate(food, vector, food.transform.rotation);
                /*pancake.transform.position.Set(-8f, 4.5f, 0f);*/
                pancake.GetComponent<Rigidbody2D>().AddForce(transform.right * 200);
            }

            if (chef.CompareTag("Chef2"))
            {
                vector = new Vector2(8f, 4.5f);
                pancake = Instantiate(food, vector, food.transform.rotation);
                /*pancake.transform.position.Set(8f, 4.5f, 0f);*/
                pancake.GetComponent<Rigidbody2D>().AddForce(transform.right * -200);
            }
            
            yield return new WaitForSeconds(Random.Range(.5f, 2f));
        }
    }
}
