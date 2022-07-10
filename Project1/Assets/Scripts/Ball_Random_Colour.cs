using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_Random_Colour : MonoBehaviour
{
    public GameObject Ball;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Pickable") ;
        {
            ChangeColor();
        }
    }
    private void ChangeColor()
    {
        Ball.gameObject.GetComponent<MeshRenderer>().material.color = Random.ColorHSV();
    }
}