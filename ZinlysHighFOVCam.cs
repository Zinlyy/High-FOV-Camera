using System;
using System.Reflection;
using BepInEx;
using Cinemachine;
using HarmonyLib;
using UnityEngine;
using GorillaLocomotion;

namespace HighFieldOfViewCam
{
    internal class ZinlysHighFOVCam
    {
        private void Update()
        {
            base.transform.position = Player.Instance.headCollider.transform.position;
            base.transform.rotation = Quaternion.Slerp(base.transform.rotation, Player.Instance.headCollider.transform.rotation, 0.9f * Time.deltaTime);
            GameObject.Find("Player Objects/Third Person Camera/Shoulder Camera").GetComponent<Camera>().fieldOfView = 95f;
            GameObject.Find("Player Objects/Third Person Camera/Shoulder Camera").GetComponent<Camera>().shutterSpeed = 9.005f;
        }
    }
}
