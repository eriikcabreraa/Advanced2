using System;
using UnityEngine;

namespace Inventory
{
    [Serializable]
    public class Other : Item, ISellable
    {

        #region Properties
        [field: SerializeField] public float Price { get; set; }
        #endregion

        #region Unity Callbacks
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
        #endregion

        #region Public Methods
        public float Sell()
        {
            Debug.Log("Has ganado " + Price + " monedas.");
            return Price;
        }

        #endregion
    }
}
