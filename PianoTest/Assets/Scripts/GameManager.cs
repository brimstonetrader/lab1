using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    
    public static GameManager Instance {get; private set;}

    private int score;

    public GameObject DiamondSpawner1;
    public GameObject DiamondSpawner2;
    public GameObject DiamondSpawner3;
    


    void Awake() {
        if (Instance == null) {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }else{
            Destroy(gameObject);
        }
    }

    public void StopGame() {
        DiamondSpawner1.GetComponent<DiamondSpawner>().StopDropping();
        DiamondSpawner2.GetComponent<DiamondSpawner>().StopDropping();
        DiamondSpawner3.GetComponent<DiamondSpawner>().StopDropping();
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
