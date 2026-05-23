using UnityEngine;

public class FireSlider : MonoBehaviour
{
    public ParticleSystem[] fireParticles;

    public void ChangeFire(float value)
    {
        if (fireParticles == null) return;
        foreach (ParticleSystem fire in fireParticles)
        {
            if (fire == null) continue;
            var main = fire.main;
            main.startSizeMultiplier = value;
        }
    }
}
