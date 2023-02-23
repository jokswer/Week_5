using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SnowmanChangesService : MonoBehaviour
{
    private const float MaxScale = 1.5f;
    private const float MinScale = 0.5f;

    [Header("UI")] [SerializeField] 
    private Slider _upperSlider;
    [SerializeField] private Slider _middleSlider;
    [SerializeField] private Slider _lowerSlider;
    [SerializeField] private TMP_Dropdown _dropdown;
    [SerializeField] private TMP_Text _nameText;

    [Header("Character")] 
    [SerializeField] private List<GameObject> _hats = new List<GameObject>();
    [SerializeField] private Transform _upperSphere;
    [SerializeField] private Transform _middleSphere;
    [SerializeField] private Transform _lowerSphere;

    private void Start()
    {
        SetValuesToSliders();
    }

    public void SetHat(int index)
    {
        for (var i = 0; i < _hats.Count; i++)
        {
            var isActive = i == index;
            _hats[i].SetActive(isActive);
        }
    }

    public void SetName(string value)
    {
        _nameText.text = value;
    }

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

    public void SetRandomValues()
    {
        var upper = Random.Range(MinScale, MaxScale);
        var middle = Random.Range(MinScale, MaxScale);
        var lower = Random.Range(MinScale, MaxScale);
        var hatIndex = Random.Range(0, _hats.Count);

        SetHat(hatIndex);
        SetUpperSphereSize(upper);
        SetMiddleSphereSize(middle);
        SetLowerSphereSize(lower);

        SetValuesToSliders();
        SetValueToDropdown(hatIndex);
    }

    private void SetValuesToSliders()
    {
        _upperSlider.value = _upperSphere.localScale.x;
        _middleSlider.value = _middleSphere.localScale.x;
        _lowerSlider.value = _lowerSphere.localScale.x;
    }

    private void SetValueToDropdown(int value)
    {
        _dropdown.value = value;
    }
}