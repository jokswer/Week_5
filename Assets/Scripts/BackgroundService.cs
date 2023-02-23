using UnityEngine;

public class BackgroundService : MonoBehaviour
{
    [SerializeField] private Renderer _background;

    public void SetMaterial(Material material)
    {
        _background.material = material;
    }
}