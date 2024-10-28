using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Assignment_8 : MonoBehaviour
{
    // Exercise 2: Funny Sentence Generator:
    void Start()
    {
        string sentence = "";
        string [] words = {"Cat", "Dog", "Car", "Pizza", "Hat", "Fish", "Tree", "Monkey", "Ball", "Bird"};
        int counter = 1;
        int index;
        while(counter <= 7){
            index = Random.Range(0,words.Length);
            if (counter == 7){
                sentence += words[index]+".";
            }
            else{
                sentence += words[index]+" ";
            }
            counter++;
        }
        Debug.Log(sentence);
    }

}
