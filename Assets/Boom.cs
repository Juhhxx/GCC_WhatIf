using NaughtyAttributes;
using UnityEngine;

public class Boom : MonoBehaviour
{
    [SerializeField] private Rigidbody _rb;

    [Button(enabledMode: EButtonEnableMode.Playmode)]
    public void DoBoom()
    {
        _rb.AddExplosionForce(5, transform.position, 5);
    }
}
