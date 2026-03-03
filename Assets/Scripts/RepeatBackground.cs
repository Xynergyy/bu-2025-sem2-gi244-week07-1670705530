using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
    private Vector3 startPos;
    private float bgWight = 0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startPos = transform.position;
        BoxCollider b = GetComponent<BoxCollider>();
        bgWight = b.size.x;
    }

    // Update is called once per frame
    void Update()
    {
        float d = startPos.x - transform.position.x;
        if (d > bgWight / 2)
        {
            transform.position = startPos;
        }

    }
}
