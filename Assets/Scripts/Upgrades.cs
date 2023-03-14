using ConaLuk;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

namespace ConaLuk
{


    public class Upgrades : MonoBehaviour
    {

        // bonus that presses the button immediately after you do

        // creates 2 sheep per button press

        // +1 money every second

        // creates 5 sheep every button press
        public GameObject extraSheep;
        [SerializeField] private Button uOne;
        [SerializeField] private Button sheepButton;
        private bool upgradeOne = false;

        private void Update()
        {

        }

        public void ExtraSheep()
        {
            if (upgradeOne == true)
            {
                Instantiate(extraSheep);
                extraSheep.transform.position = new Vector3(34, 3, -33);

            }
        }

        public void UpgradeOne()
        {
            upgradeOne = true;
            // change the spritye to something else
        }



    }
}