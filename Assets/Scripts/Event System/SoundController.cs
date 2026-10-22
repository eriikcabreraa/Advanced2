using UnityEngine;

public class SoundController : MonoBehaviour
{
    #region Properties
    #endregion

    #region Fields
    [SerializeField] private AudioClip _damageSound;
    [SerializeField] private AudioClip _dieSound;
    private AudioSource _audioSource;
    #endregion

    #region Unity Callbacks
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _audioSource = GetComponent<AudioSource>();
    }

    #endregion

    #region Public Methods
    public void PlayDamageSound()
    {
        _audioSource.clip = _damageSound;
        _audioSource.Play();
        Debug.Log("Damage sound played");
    }
    public void PlayDieSound()
    {
        _audioSource.clip = _dieSound;
        _audioSource.Play();
        Debug.Log("Die sound played");
    }
    #endregion

    #region Private Methods
    #endregion
}

