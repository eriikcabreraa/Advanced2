using System;
using UnityEngine;

namespace Inventory
{
    [Serializable]
    public class Weapon : Item, IUsable
    {
        #region Properties
        [field: SerializeField] public float Damage { get; set; }
        #endregion

        #region Fields
        #endregion


        #region Public Methods
        public void Attack()
        {
            Debug.Log("Do atack");
        }

        public void Use()
        {
            Attack();
        }
        #endregion

        #region Private Methods
        #endregion
    }
}
