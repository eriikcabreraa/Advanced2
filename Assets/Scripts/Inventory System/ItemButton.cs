using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Inventory
{
    [Serializable]
    public class ItemButton : MonoBehaviour
    {
        #region Properties
        public Item CurrentItem
        {
            get
            {
                return _currentItem;
            }
            set
            {
                _currentItem = value;
                _buttonText.text = _currentItem.Name;
                   
            }
        }
        public event Action OnClick;
        #endregion

        #region Fields
        private TextMeshProUGUI _buttonText; 
        private Button _button; 
        private Item _currentItem;
        #endregion

        #region Unity Callbacks
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Awake()
        {
            _button = GetComponent<Button>();
            _buttonText = GetComponentInChildren<TextMeshProUGUI>();
            _button.onClick.AddListener(() => OnClick?.Invoke());
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

