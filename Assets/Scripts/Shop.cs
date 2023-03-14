using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ConaLuk
{
    public class Shop : MonoBehaviour
    {
        [SerializeField] private Canvas shopcanvas;

        [SerializeField] private Button upgradeOne;
        [SerializeField] private Button upgradeTwo;
        [SerializeField] private Button upgradeThree;
        [SerializeField] private Button upgradeFour;

        private void Start()

        {
            shopcanvas.enabled = false;
            upgradeOne.enabled = false;
            upgradeTwo.enabled = false;
            upgradeThree.enabled = false;
            upgradeFour.enabled = false;

        }

        public void ShopOn()
        {
            shopcanvas.enabled=true;
        }


    }
}