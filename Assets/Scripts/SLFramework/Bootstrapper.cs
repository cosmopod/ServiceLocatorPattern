using Services;
using UnityEngine;

namespace SLFramework
{
    public class Bootstrapper
    {
        [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
        public static void Initialize()
        {
            // Initialize default service locator.
            ServiceLocator.Initialize();
            
            
            // Register all your services next.
            ServiceLocator.Current.Register(new AudioService());
            ServiceLocator.Current.Register(new PersistenceService());
        }
    }
}