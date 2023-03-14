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
        [SerializeField] private Button uTwo;
        [SerializeField] private Material coolDude;
        private bool clickedOnce = false;
        private bool upgradeOne = false;
        private bool upgradeTwo = false;
        private bool upgradeThree = false;
        private bool upgradeFour = false;
        


        private void Start()
        {
            
            sheepButton.onClick.AddListener(OnClickSheepButton);
            sheepButton.onClick.AddListener(SheepSplosion);
        }

        public void ExtraSheep()
        {
            if (upgradeOne == true)
            {
                Instantiate(extraSheep);
                extraSheep.transform.position = new Vector3(34, 3, -33);

            }
        }
        private void OnClickSheepButton()
        {
            if (upgradeTwo == true)
            {
                if (clickedOnce == false)
                {
                    clickedOnce = true;
                    sheepButton.interactable = false;
                    sheepButton.onClick.Invoke();
                    sheepButton.interactable = true;
                    clickedOnce = false;
                }
            }
        }

        public void CoolDude()
        {
            if(upgradeThree == true)
            {
                extraSheep.GetComponent<Renderer>().material = coolDude;
            }
        }

        private void SheepSplosion()
        {
            if (upgradeFour == true)
            {
                sheepButton.interactable = false;
                sheepButton.onClick.Invoke();
                sheepButton.interactable = true;
            }
        }

        public void UpgradeOne()
        {
            upgradeOne = true;
        }

        public void UpgradeTwo()
        {
            upgradeTwo = true;
        }

        public void UpgradeThree()
        {
            upgradeThree = true;
        }

        public void UpgradeFour()
        {
            upgradeFour = true;
        }
    }
}