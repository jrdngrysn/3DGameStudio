using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTrigger : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Renderer render = GetComponent<Renderer>();
            render.material.color = Color.green;
            GameManager.Instance.OnArchEnter(this.gameObject);
        }
    }

    void OnTriggerExit(Collider other)
    {

    }
}
