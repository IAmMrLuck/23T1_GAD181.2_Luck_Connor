using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ConaLuk
{

    public class DestroySheep : MonoBehaviour
    {

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.activeSelf)
            {
                Destroy(other.gameObject);
            }

        }

    }
}
