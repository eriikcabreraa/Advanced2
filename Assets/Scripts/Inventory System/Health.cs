using UnityEngine;

namespace Inventory
{
    public class Health : MonoBehaviour
    {
        #region Properties
        #endregion

        #region Fields
        [SerializeField] private int _currentHealth = 100;
        [SerializeField] private int _maxHealth = 100;
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
        public void TakeDamage()
        {
            if (_currentHealth > 0)
            {
                _currentHealth -= 10;
                Debug.Log("Take Damage: " + _currentHealth);
            }
            if (_currentHealth <= 0)
            {
                Debug.Log("You are dead!");
            }
        }

        public void Heal()
        {
            if (_currentHealth < _maxHealth)
            {
                _currentHealth += 10;
                Debug.Log("Heal: " + _currentHealth);
            }
            else
            {
                Debug.Log("Health is full: " + _currentHealth);
            }
        }
        #endregion

        #region Private Methods
        #endregion
    }
}

