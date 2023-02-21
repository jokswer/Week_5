using UnityEngine;

public class SnowmanChangesService : MonoBehaviour
{
    [SerializeField] private Transform _upperSphere;
    [SerializeField] private Transform _middleSphere;
    [SerializeField] private Transform _lowerSphere;
    
    public void SetUpperSphereSize(float value)
    {
        _upperSphere.localScale = new Vector3(value, value, value);
    }
    
    public void SetMiddleSphereSize(float value)
    {
        _middleSphere.localScale = new Vector3(value, value, value);
    }
    
    public void SetLowerSphereSize(float value)
    {
        _lowerSphere.localScale = new Vector3(value, value, value);
    }
}
