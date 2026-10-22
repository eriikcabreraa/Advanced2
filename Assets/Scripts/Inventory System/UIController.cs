using UnityEngine;
using TMPro;

namespace Inventory
{
    public class UIController : MonoBehaviour
    {
        #region Properties
        #endregion

        #region Fields
        [SerializeField] private TextMeshProUGUI _levelText;

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
        public void UpdateLevel(int level)
        {
            _levelText.text = "Level: " + level.ToString();
        }
        #endregion

        #region Private Methods
        #endregion
    }
}

