using System.Collections.Generic;
using UnityEngine;

public class ColliderGenerator : MonoBehaviour
{
    [SerializeField]
    private float _colliderSize;
    [SerializeField]
    private GameObject _colliderPrefab;

    private List<GameObject> _colliders = new List<GameObject>();

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GenerateColliders();
    }

    private void GenerateColliders()
    {

        float x = transform.lossyScale.x;
        float y = transform.lossyScale.y;

        int amountX = Mathf.FloorToInt(x / _colliderSize);
        int amountY = Mathf.FloorToInt(y / _colliderSize);

        float paddingX = 0;
        float paddingY = 0;

        _colliders = new List<GameObject>();

        if (amountX > 1)
        {
            paddingX = (x - (amountX * _colliderSize)) / (amountX - 1);
            paddingX /= transform.lossyScale.x;
        }
        if (amountY > 1)
        {
            paddingY = (y - (amountY * _colliderSize)) / (amountY - 1);
            paddingY /= transform.lossyScale.y;
        }

        float normalizedColliderSizeX = _colliderSize / transform.lossyScale.x;
        float normalizedColliderSizeY = _colliderSize / transform.lossyScale.y;

        Vector2 bottomLeft = new Vector3(-.5f + normalizedColliderSizeX / 2, -.5f + normalizedColliderSizeY / 2, 0);

        for (int i = 0; i < amountX; i++)
            for(int j = 0; j < amountY; j++)
            {
                GameObject collider = GameObject.Instantiate(_colliderPrefab);
                collider.transform.localScale = new Vector2(_colliderSize, _colliderSize);
                collider.transform.SetParent(transform);
                collider.transform.localPosition = bottomLeft + new Vector2((normalizedColliderSizeX + paddingX) * i, (normalizedColliderSizeY + paddingY) * j);

                _colliders.Add(collider);
            }
    }
}
