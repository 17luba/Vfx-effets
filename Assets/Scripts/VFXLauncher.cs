using UnityEngine;
using UnityEngine.VFX;

public class VFXLauncher : MonoBehaviour
{
    public VisualEffect impactVFX;
    public Transform spawnPoint; // Facultatif : l� o� l�effet se joue

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Positionner l'effet � un endroit pr�cis (ex: devant un joueur)
            if (spawnPoint != null)
                impactVFX.transform.position = spawnPoint.position;

            // D�clencher l'effet
            impactVFX.Play();
        }
    }
}
