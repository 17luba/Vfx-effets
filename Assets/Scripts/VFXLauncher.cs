using UnityEngine;
using UnityEngine.VFX;

public class VFXLauncher : MonoBehaviour
{
    public VisualEffect impactVFX;
    public Transform spawnPoint; // Facultatif : là où l’effet se joue

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Positionner l'effet à un endroit précis (ex: devant un joueur)
            if (spawnPoint != null)
                impactVFX.transform.position = spawnPoint.position;

            // Déclencher l'effet
            impactVFX.Play();
        }
    }
}
