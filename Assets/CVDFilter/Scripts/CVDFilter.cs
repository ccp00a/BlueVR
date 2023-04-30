﻿using UnityEngine;
using UnityEngine.Rendering;
using UnityEditor;
using System.Reflection;

namespace SOG.CVDFilter
{
    [ExecuteAlways]
    [DisallowMultipleComponent]
    [RequireComponent(typeof(Volume))]
    public class CVDFilter : MonoBehaviour
    {
        Volume postProcessVolume;

        CVDProfilesSO profiles;
        [SerializeField] VisionTypeNames currentType;
        public VisionTypeInfo SelectedVisionType { get; private set; }

        const string soFileName = "CVDProfiles";
        const string soSearchTerm = "t:ScriptableObject " + soFileName;

        void Reset()
        {
            Setup();
            ChangeProfile();
        }

        void Start()
        {
            Setup();
            ChangeProfile();
        }


        void Setup()
        {
            AssignProfileSO();
            ConfigureVolume();
        }

        void AssignProfileSO()
        {
#if UNITY_EDITOR
            string[] guid = AssetDatabase.FindAssets(soSearchTerm);
            if (guid.Length < 1)
            {
                Debug.LogErrorFormat("[{0}] ({1}): Error - Unable to locate file \"{2}\". "
                + "There should be a single ScriptableObject called \"{2}.asset\" in CVDFilter > Scripts", GetType().Name, MethodBase.GetCurrentMethod().Name, soFileName);
                return;
            }

            profiles = AssetDatabase.LoadAssetAtPath<CVDProfilesSO>(AssetDatabase.GUIDToAssetPath(guid[0]));
            SelectedVisionType = profiles.VisionTypes[0];

            if (guid.Length > 1)
            {
                Debug.LogWarningFormat("[{0}] ({1}): Warning - Multiple {2} found. \"{3}\" has been loaded.", GetType().Name, MethodBase.GetCurrentMethod().Name, soFileName, profiles.name);
            }
#endif
        }

        void ConfigureVolume()
        {
            postProcessVolume = GetComponent<Volume>();
            postProcessVolume.isGlobal = true;
        }

        public void ChangeProfile()
        {
            if (profiles == null)
            {
                Debug.LogErrorFormat("[{0}] ({1}): Error - Unable to locate {2}.", GetType().Name, MethodBase.GetCurrentMethod().Name, soFileName);
                return;
            }

            SelectedVisionType = profiles.VisionTypes[(int)currentType];
            postProcessVolume.profile = SelectedVisionType.profile;
            return;
        }
    }

    public enum VisionTypeNames
    {
        Normal,
        Protanopia,
        Protanomaly,
        Deuteranopia,
        Deuteranomaly,
        Tritanopia,
        Tritanomaly,
        Achromatopsia,
        Achromatomaly
    }

    [System.Serializable]
    public struct VisionTypeInfo
    {
        public VisionTypeNames typeName;
        public string description;
        public VolumeProfile profile;
        public Texture2D previewImage;
    }
}