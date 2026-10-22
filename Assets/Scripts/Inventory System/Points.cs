using System;
using UnityEngine;

namespace Inventory
{
    public class Points : MonoBehaviour
    {
        #region Properties
        public int CurrentLevel
        {
            get { return _currentLevel; }
            set { _currentLevel = value; }
        }
        public event Action OnLevelChanged;
        #endregion

        #region Fields
        [SerializeField] private int _currentPoints = 0;
        [SerializeField] private int _currentLevel = 1;
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
        public void AddPoints()
        {
            _currentPoints += 10;
            Debug.Log("Current Points: " + _currentPoints);
        }

        public void AddLevel()
        {
            _currentLevel++;
            Debug.Log("Current Level: " + _currentLevel);
            OnLevelChanged?.Invoke();
        }
        #endregion

        #region Private Methods
        #endregion
    }
}

