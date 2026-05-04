// --------------------------------------------------------------
// Copyright 2026 CyberAgent, Inc.
// --------------------------------------------------------------

#nullable enable

using AudioConductor.Editor.Core.Models;
using UnityEditor;
using UnityEditor.Callbacks;

namespace AudioConductor.Editor.Core.Tools.CodeGen
{
    internal static class CueEnumDefinitionOpener
    {
        [OnOpenAsset(0)]
        public static bool OnOpen(int instanceID, int line)
        {
#if UNITY_6000_5_OR_NEWER
            var asset = EditorUtility.EntityIdToObject(instanceID);
#else
            var asset = EditorUtility.InstanceIDToObject(instanceID);
#endif

            if (asset is not CueEnumDefinition definition)
                return false;

            CueEnumDefinitionEditorWindow.Open(definition);
            return true;
        }
    }
}
