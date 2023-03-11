using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

namespace ConaLuk
{

    public class SheepMove : MonoBehaviour
    {
        [SerializeField] GameObject barn;
        [SerializeField] private float moveSpeed = 1;

        public void Update()
        {
            transform.position = Vector3.MoveTowards(transform.position, barn.transform.position, moveSpeed *Time.deltaTime);
            
        }
    }
}