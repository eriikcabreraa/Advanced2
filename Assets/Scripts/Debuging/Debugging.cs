using UnityEngine;

public class Debugging : MonoBehaviour
{
    #region Properties
    #endregion

    #region Fields
    [Header("Gizmo Line")]
    [SerializeField] private Vector3 _initialGizmoLine;
    [SerializeField] private Vector3 _finalGizmoLine;

    [Header("Vision Area")]
    [SerializeField] private int _visionLenght = 10;

    [Header("Detection Area")]
    [SerializeField] private int _visionArea = 10;
    [SerializeField] private int _audioArea = 30;


    private int _cont = 0;
    
    #endregion

    #region Unity Callbacks
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Mensaje");
        Debug.LogWarning("Mensaje tipo Warning");
        Debug.LogError("Mensaje tipo Error");
    }


    // Update is called once per frame
    void Update()
    {
        _cont++;
        if (_cont % 100 == 0)
        {
            Debug.Log("Contador: " + _cont);
        }
    }
    #endregion

    #region Public Methods
    #endregion

    #region Private Methods
    #endregion

    #region Gizmos
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.white;
        Gizmos.DrawLine(_initialGizmoLine, _finalGizmoLine);
        Gizmos.DrawWireSphere(Vector3.zero, _visionArea);
        Gizmos.color = Color.red;
        Gizmos.DrawLine(Vector3.zero, _visionLenght * (Vector3.forward + Vector3.right ));
        Gizmos.DrawLine(Vector3.zero, _visionLenght * (Vector3.forward + Vector3.left ));
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(Vector3.zero, _audioArea);
    }
    #endregion

}

