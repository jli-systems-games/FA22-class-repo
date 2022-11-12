using Nickel.NickelBalanace.TheFirstPerson.Code.Player;
using UnityEngine;

//plays a sound when you jump. the simplest example plugin.

namespace Nickel.NickelBalanace.TheFirstPerson.Code.ExampleExtensions.JumpSound
{
    public class JumpSound : TFPExtension
    {

        public AudioSource src;
        public AudioClip sound;

        public override void ExPostUpdate(ref TFPData data, TFPInfo info)
        {
            if (data.timeSinceGrounded <= Time.deltaTime && data.jumping)
            {
                src.PlayOneShot(sound);
            }
        }

    }
}
