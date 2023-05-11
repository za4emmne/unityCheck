using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class waterDead : MonoBehaviour
{
    private Animator _animator;

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.TryGetComponent<Player>(out Player player))
        {

        }
    }
}
