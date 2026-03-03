using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float speed = 10f;

    private PlayerController playerControllerScript;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameObject go = GameObject.Find("Player");
        if (go != null)
        {
            playerControllerScript = go.GetComponent<PlayerController>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (playerControllerScript != null && !playerControllerScript.isGameOver)
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
    }
}
