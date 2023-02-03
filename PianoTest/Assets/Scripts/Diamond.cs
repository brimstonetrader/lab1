using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diamond : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col) {
        print("oh no they hit us");
        if (col.gameObject.tag == "Cat"){
            GameManager.Instance.StopGame();
            Destroy(col.gameObject);
        }
    }
}
