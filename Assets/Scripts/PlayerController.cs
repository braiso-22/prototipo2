using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float verticalInput;
    public float speed = 10.0f;
    private float bordeHorizontal = 21f;
    public float bordeVertical = 8f;
    public GameObject proyectilPrefab;

    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * speed);

        if (Mathf.Abs(transform.position.x) > bordeHorizontal)
        {
            transform.position = new Vector3(bordeHorizontal * Mathf.Sign(horizontalInput), 0, transform.position.z);
        }
        if (Mathf.Abs(transform.position.z) > bordeVertical)
        {
            transform.position = new Vector3(transform.position.x, 0, bordeVertical * Mathf.Sign(verticalInput));
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(proyectilPrefab, new Vector3(transform.position.x,1,transform.position.z+1), proyectilPrefab.transform.rotation);
        }
    }
}
