using System;
using UnityEngine;

public class EventSystem : MonoBehaviour
{
    #region Properties
    #endregion

    #region Fields
    [SerializeField] private Points _points;
    [SerializeField] private Health _playerHealth;
    [SerializeField] private UIController _uiController;
    [SerializeField] private SoundController _soundController;
    #endregion

    #region Unity Callbacks
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Event listener
        _playerHealth.OnGetDamage += OnGetDamage;
        _playerHealth.OnGetHeal += OnGetHeal;
        _playerHealth.OnDie += OnDie;
        _points.OnGetPoints += () => OnAddPoints();
    }

   

    // Update is called once per frame
    void Update()
    {
             
    }
    #endregion

    #region Public Methods
    #endregion

    #region Private Methods
    private void OnGetDamage()
    {
        _soundController.PlayDamageSound();
        _uiController.UpdateSliderLife(_playerHealth.CurrentHealth);
    }

    private void OnDie()
    {
        _soundController.PlayDieSound();
        Destroy(_playerHealth.gameObject);
    }
    private void OnGetHeal()
    {
        _uiController.UpdateSliderLife(_playerHealth.CurrentHealth);
    }
    private void OnAddPoints()
    {
        _uiController.UpdatePoints(_points.CurrentPoints);
    }
    #endregion
}

