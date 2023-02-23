using TMPro;
using UnityEngine;

namespace Utils
{
    [RequireComponent(typeof(TMP_InputField))]
    public class MaxInputLenght : MonoBehaviour
    {
        private TMP_InputField _inputField;
        [SerializeField] private int _characterLimit = 11;
        
        private void Awake()
        {
            _inputField = GetComponent<TMP_InputField>();
            _inputField.characterLimit = _characterLimit;
        }
    }
}