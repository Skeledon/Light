using UnityEngine;

[RequireComponent (typeof(IColorChange))]
public class ColorChange : MonoBehaviour
{
    public void SetColor(ColorState.State state)
    {
        GetComponent<IColorChange>().SetColor(state);
    }
}
