using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinColourRotation : MonoBehaviour
{
    public GameObject Coins;

    void Start()
    {
        Coins.GetComponent<MeshRenderer>().material.color = Color.grey;
    }

    // Update is called once per frame
    void Update()
    {
        Coins.transform.Rotate(new Vector3(2, 3, 4 * Time.deltaTime));
        Coins.GetComponent<MeshRenderer>().material.color = Color.Lerp(Color.red, Color.yellow, Mathf.PingPong(Time.time, 1));
    }
}
