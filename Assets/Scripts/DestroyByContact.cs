﻿using UnityEngine;
using System.Collections;

public class DestroyByContact : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Boundary")
        {
            return;
        }
        Debug.Log("kaas");
        Destroy(other.gameObject);
        Destroy(gameObject);
    }
}