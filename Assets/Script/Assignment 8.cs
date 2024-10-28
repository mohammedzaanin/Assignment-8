using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Assignment8 : MonoBehaviour
{
    // Exercise 1: Number Generator:
    void Start()
    {
        int randomnumbers; 
        while(true){
            randomnumbers = Random.Range(1,20);
            if(randomnumbers == 5){
                continue;
            }
            else{
                
                if(randomnumbers == 15){
                break;
                }
                Debug.Log(randomnumbers);
            }

        }
        
    }

}
