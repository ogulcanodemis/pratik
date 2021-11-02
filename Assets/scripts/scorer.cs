using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scorer : MonoBehaviour
{
    int hits = 0;
    
    private void OnCollisionEnter(Collision collision)
    {
        hits++;
        Debug.Log("usta biþilere çarpýyosun ustaa" + hits);
    }
}
