using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    public float radius = 3f;
    public Transform player;
    public Transform InteractionTransform;

    public virtual void Interact()
    {
        Debug.Log("Interact with " + transform.name);
    }

    private void Update()
    {
        float distance = Vector3.Distance(player.position, InteractionTransform.position);
        if(distance <= radius)
        {
            Interact();
            Debug.Log("Interact");
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(InteractionTransform.position, radius);
    }
}
