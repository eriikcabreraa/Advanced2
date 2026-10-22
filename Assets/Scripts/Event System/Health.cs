using System;
using UnityEngine;

public class Health : MonoBehaviour
{
    #region Properties
    public float CurrentHealth
    {
        get
        {
            return _currentHealth;
        }
        set
        {
            _currentHealth = value;
            if (value <= 0)
            {
                _currentHealth = 0;
                Die();
            }

            if (value > _maxHealth)
                _currentHealth = _maxHealth;
        }
    }

    public event Action OnGetDamage;
    public event Action OnGetHeal;
    public event Action OnDie;
    #endregion

    #region Fields
    [SerializeField] private float _currentHealth;
    [SerializeField] private float _maxHealth = 100;
    [SerializeField] private bool _die = false;
    #endregion

    #region Unity Callbacks
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        CurrentHealth = _maxHealth;

        //Test
        //GetDamage(20);
        //GetHeal(50);
        //GetDamage(100);
        //GetDamage(50);

    }

    // Update is called once per frame
    //void Update()
    //{
    //    if (Input.GetKeyUp(KeyCode.Return))
    //    {
    //        GetDamage(20);
    //    }
    //    if (Input.GetKeyUp(KeyCode.Space))
    //    {
    //        GetHeal(20);
    //    }
    //}
    #endregion

    #region Public Methods
    public void GetDamage(float damage)
    {
        if (!_die)
        {
            CurrentHealth -= damage;
            //Event emitter
            OnGetDamage?.Invoke();
        }

    }

    public void GetHeal(float life)
    {
        if (!_die)
        {
            CurrentHealth += life;
            //Event emitter
            OnGetHeal?.Invoke();
        }
    }

    #endregion

    #region Private Methods

    private void Die()
    {
        if (!_die)
        {
            _die = true;
            //Event emitter
            OnDie?.Invoke();
        }
    }
    #endregion
}

