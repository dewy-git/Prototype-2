using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    private float countAfterPress = 0f;
    private float scalePressFrequency = 0.9f;
    // Update is called once per frame
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && countAfterPress < 1)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            countAfterPress += 1;
        }else
        {
            countAfterPress -= Time.deltaTime * scalePressFrequency;
        }
    }
}