using System;
using UnityEngine;

namespace Inventory
{
    [Serializable]
    public class Item
    {
        #region Properties
        [field: SerializeField] public string Name { get; set; }
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
        #endregion

        #region Private Methods
        #endregion
    }
}

