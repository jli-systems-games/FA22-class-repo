using UnityEngine;

//this object defines a pool of sounds to pull from when a texture in the textures array is detected beneath the player

namespace AishaBikebayeva.AishaLifelike.Scripts.TheFirstPerson.Code.ExampleExtensions.FootstepSystem
{
    [CreateAssetMenu(fileName = "Data", menuName = "Footstep Group", order = 1)]
    public class FootstepGroup : ScriptableObject
    {
        public AudioClip[] footSounds;
        public Texture2D[] textures;
    }
}
