using System;
using UnityEngine;

namespace Inventory
{
    [Serializable]
    public class InputSystem : MonoBehaviour
    {
        #region Properties
        public event Action OnKeyDamage;
        public event Action OnKeyHeal;
        public event Action OnKeyPoints;
        public event Action OnKeyAddLevel;
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
            if (Input.GetKeyDown(KeyCode.D))
            {
                OnKeyDamage?.Invoke();
            }
            if (Input.GetKeyDown(KeyCode.H))
            {
                OnKeyHeal?.Invoke();
            }
            if (Input.GetKeyDown(KeyCode.P))
            {
                OnKeyPoints?.Invoke();
            }
            if (Input.GetKeyDown(KeyCode.L))
            {
                OnKeyAddLevel?.Invoke();
            }
        }
        #endregion
        #region Public Methods
        #endregion
        #region Private Methods
        #endregion
    }
}

