using UnityEngine;

public class Bomb : MonoBehaviour
{
    private AudioSource explodeAudio;

    private void Awake()
    {
        explodeAudio = GetComponent<AudioSource>(); // Get the AudioSource component
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GetComponent<Collider>().enabled = false;
            explodeAudio.Play(); // Play the explode audio
            GameManager.Instance.Explode();
        }
    }
}
