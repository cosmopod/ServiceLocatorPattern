using UnityEngine;

namespace Services
{
    public class AudioService : IGameService
    {
        public void PlaySound(string soundId)
        {
            Debug.Log("Play sound: " + soundId);
        }
    }
}