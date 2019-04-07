using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace YacmanGame
{
    public class Pacdot : MonoBehaviour
    {
        void OnTriggerEnter2D(Collider2D co)
        {
            if (co.name == "Yacman")
                Destroy(gameObject);
        }
    }
}