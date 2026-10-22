using System;
using System.Collections.Generic;
using Unity.VisualScripting.Dependencies.NCalc;
using UnityEngine;
using UnityEngine.UI;

namespace Inventory
{
    public class InventorySystem : MonoBehaviour
    {
        #region Properties
        #endregion
        //TODO: Refactor: move this to UIControler
        #region Fields
        [Header("UI References")]
        [SerializeField] private ItemButton _prefabButton;
        [SerializeField] private Transform _inventoryPanel;
        [SerializeField] private Button _useButton;
        [SerializeField] private Button _sellButton;


        [Header("Object Definition")]
        [SerializeField] private Weapon[] _weapons;
        [SerializeField] private Food[] _foods;
        [SerializeField] private Other[] _others;

        [Header("Item Pool")]
        [SerializeField] private List<Item> _items = new List<Item>();
        [Header("Item Selected")]
        [SerializeField] private ItemButton _currentItemSelected;
        #endregion

        #region Unity Callbacks
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            initializeItems();
            initializeUI();

            //TODO: Refactor: move this to UIControler
            _useButton.onClick.AddListener(UseCurrentItem);
            _sellButton.onClick.AddListener(SellCurrentItem);
        }

       

        // Update is called once per frame
        void Update()
        {

        }
        #endregion

        #region Public Methods
        public void AddItem(ItemButton buttonItemToAdd)
        {
            ItemButton newButtonItem = Instantiate(buttonItemToAdd, _inventoryPanel);
            newButtonItem.CurrentItem = buttonItemToAdd.CurrentItem;
            newButtonItem.OnClick += () => SelectItem(newButtonItem);


        }

        public void SelectItem(ItemButton currentItem)
        {
            _currentItemSelected = currentItem;
            //Logica de control de botones de acciones
            if (_currentItemSelected.CurrentItem is ISellable)
            {
                _sellButton.gameObject.SetActive(true);
            }
            else
            {
                _sellButton.gameObject.SetActive(false);
            }

            if (_currentItemSelected.CurrentItem is IUsable)
            {
                _useButton.gameObject.SetActive(true);
            }
            else
            {
                _useButton.gameObject.SetActive(false);
            }
        }
        #endregion

        #region Private Methods
        private void initializeItems()
        {
            //Weapons
            for (int i = 0; i < _weapons.Length; i++)
            {
                _items.Add(_weapons[i]);
            }
            //Foods
            for (int i = 0; i < _foods.Length; i++)
            {
                _items.Add(_foods[i]);
            }
            //Others
            for (int i = 0; i < _others.Length; i++)
            {
                _items.Add(_others[i]);
            }
        }
        private void initializeUI()
        {
            for (int i = 0; i < _items.Count; i++)
            {
                ItemButton newButton = Instantiate(_prefabButton, _prefabButton.transform.parent);
                newButton.CurrentItem = _items[i];
                newButton.OnClick += () => AddItem(newButton);
            }
            _prefabButton.gameObject.SetActive(false);
        }
        //TODO: Refactor: move this to UIControler
        private void SellCurrentItem()
        {
            (_currentItemSelected.CurrentItem as ISellable).Sell();
            Consume(_currentItemSelected);
        }

        private void UseCurrentItem()
        {
            (_currentItemSelected.CurrentItem as IUsable).Use();
            if (_currentItemSelected.CurrentItem is IConsumable)
            {
                Consume(_currentItemSelected);
            }
        }

        private void Consume(ItemButton currentItemSelected)
        {
            Destroy(_currentItemSelected.gameObject);
            _currentItemSelected = null;
            _sellButton.gameObject.SetActive(false);
            _useButton.gameObject.SetActive(false);
        }

        #endregion
    }
}

