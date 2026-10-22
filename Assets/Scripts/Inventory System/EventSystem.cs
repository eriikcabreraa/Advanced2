using UnityEngine;

namespace Inventory
{
    public class EventSystem : MonoBehaviour
    {
        #region Properties
        #endregion

        #region Fields
        [SerializeField] private InputSystem _inputs;
        [SerializeField] private Health _health;
        [SerializeField] private Points _points;
        [SerializeField] private UIController _uiController;

        #endregion

        #region Unity Callbacks
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            _inputs.OnKeyDamage += TakeDamage;
            _inputs.OnKeyHeal += Heal;
            _inputs.OnKeyPoints += AddPoints;
            _inputs.OnKeyAddLevel += AddLevel;
            _points.OnLevelChanged += UpdateLevelUI;
        }

        // Update is called once per frame
        void Update()
        {

        }
        #endregion

        #region Public Methods
        #endregion

        #region Private Methods
        private void TakeDamage()
        {
            _health.TakeDamage();
        }
        private void Heal()
        {
            _health.Heal();
        }

        private void AddPoints()
        {
            _points.AddPoints();
        }

        private void AddLevel()
        {
            _points.AddLevel();
        }

        private void UpdateLevelUI()
        {
            _uiController.UpdateLevel(_points.CurrentLevel);
        }
        #endregion
    }
}
