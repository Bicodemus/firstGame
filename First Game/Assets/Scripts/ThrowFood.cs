using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowFood : MonoBehaviour
{

    public GameObject food;
    // Start is called before the first frame update
    void Start()
    {
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
            Instantiate(food);
            yield return new WaitForSeconds(Random.Range(1f, 4f));
        }
    }
}
