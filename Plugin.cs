using System;
using System.Reflection;
using BepInEx;
using Cinemachine;
using HarmonyLib;
using UnityEngine;
using GorillaLocomotion;

namespace HighFieldOfViewCam
{
    [BepInDependency("org.legoandmars.gorillatag.utilla", "1.5.0")]
    [BepInPlugin(PluginInfo.GUID, PluginInfo.Name, PluginInfo.Version)]
    public class Plugin : BaseUnityPlugin
    {
        public void Awake()
        {
            new Harmony("com.zinly.gorillatag.highfieldofviewcam").PatchAll(Assembly.GetExecutingAssembly());
        }
    }
}
