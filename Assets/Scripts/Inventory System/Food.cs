using System;
using UnityEngine;

namespace Inventory
{
    public interface IConsumable{}
    [Serializable]
    public class Food : Item, ISellable, IUsable, IConsumable
    {
        #region Properties
        [field: SerializeField] public float HealingPoints { get; set; }
        [field: SerializeField] public float Price { get; set; }

        #endregion

        #region Fields
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
        public void Use()
        {
            Debug.Log("Has consumido " + Name + " y has recuperado " + HealingPoints + " puntos de vida.");
        }

        public float Sell()
        {
            Debug.Log("Has ganado " + Price + " monedas.");
            return Price;
        }
        #endregion

        #region Private Methods
        #endregion
    }
}
