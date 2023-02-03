using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomDiamondMovement : MonoBehaviour
{



    void OnTriggerEnter2D(Collider2D col) {
        if (col.gameObject.tag == "Gem"){
            col.transform.position = new Vector2(Random.Range(-5f, 5f), Random.Range(-5f, 5f));
            }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
