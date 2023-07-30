using UnityEngine;

public class Chest : MonoBehaviour
{
    [SerializeField] 
    private Animator _animator;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(GlobalConstants.PLAYER_TAG))
        {
            Open();
        }
    }

    private void Open()
    {
        _animator.SetTrigger("open");
    }
}