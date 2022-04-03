using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    void onCollisionEnter2D(Collision2D other){
        Debug.Log("Ouch!");
    }
}
