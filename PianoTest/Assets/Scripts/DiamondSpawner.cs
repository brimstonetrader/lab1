using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiamondSpawner : MonoBehaviour
{

    public GameObject Diamond;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("DropDiamond");
    }
    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator DropDiamond() {
        for (;;) {
            Instantiate(Diamond);
            yield return new WaitForSeconds(Random.Range(0.5f, 1.5f));
        }
    }
}
