using System;
using Services;
using SLFramework;
using UnityEngine;

namespace GameLogic
{
    public class Player : MonoBehaviour
    {
        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                Attack();
            }
        }

        private void Attack()
        {
            ServiceLocator.Current.Get<AudioService>().PlaySound("Attack Sound");
        }
    }
}