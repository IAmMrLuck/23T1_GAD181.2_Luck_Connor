using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

namespace ConaLuk
{

    public class SheepMove : MonoBehaviour
    {
        [SerializeField] private GameObject barn;
        [SerializeField] private float moveSpeed = 1;

        private void Start()
        {
            gameObject.tag = "Sheep";
        }
        public void Update()
        {
            transform.position = Vector3.MoveTowards(transform.position, barn.transform.position, moveSpeed *Time.deltaTime);
            
        }

    }
}