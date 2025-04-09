using UnityEngine;

public class RaycastTester : MonoBehaviour
{
    public LayerMask _layerMask;
    public int _maxDistance;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            RaycastHit2D[] hits = Physics2D.RaycastAll(transform.position, transform.right, _maxDistance, _layerMask);
            RaycastHit2D temp;
            if (hits.Length == 0)
                return;
            if (hits.Length > 1)
            {
                for (int i = 1; i < hits.Length; i++)
                {
                    for (int j = 1; j < hits.Length; j++)
                    {
                        if (hits[j].distance < hits[j - 1].distance)
                        {
                            temp = hits[j];
                            hits[j] = hits[j - 1];
                            hits[j - 1] = temp;
                        }
                    }
                }
            }
            foreach (RaycastHit2D hit in hits)
            {
                Debug.Log(hit.point);
            }
        }
    }
}
