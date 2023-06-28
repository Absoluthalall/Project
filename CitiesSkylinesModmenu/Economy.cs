using ColossalFramework;
using UnityEngine;

namespace CitiesSkylinesModmenu
{
    internal class Economy : MonoBehaviour
    { 
        internal static void AddCash(long amount)
        {
            EconomyManager em = Singleton<EconomyManager>.instance;
            em.m_cashAmount += amount;
        }

        internal static void Render()
        {
            if (GUI.Button(new Rect(20f, 20f, 100f, 20f), "Add Cash"))
                AddCash(1000000);
        }
    }
}
