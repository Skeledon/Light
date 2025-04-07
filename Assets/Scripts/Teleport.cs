using UnityEngine;

public class Teleport : MonoBehaviour
{
    [SerializeField]
    private Transform _target;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.gameObject.transform.position = _target.position;
    }
}
