// --------------------------------------------------------------
// Copyright 2026 CyberAgent, Inc.
// --------------------------------------------------------------

#nullable enable

using AudioConductor.Core.Models;
using UnityEditor;
using UnityEditor.Callbacks;

namespace AudioConductor.Editor.Core.Tools.CueSheetEditor
{
    internal static class CueSheetAssetOpener
    {
        [OnOpenAsset(0)]
        public static bool OnOpen(int instanceID, int line)
        {
            var assetPath = AssetDatabase.GetAssetPath(instanceID);
            var asset = AssetDatabase.LoadMainAssetAtPath(assetPath);

            if (asset is not CueSheetAsset data)
                return false;

            CueSheetAssetEditorWindow.Open(data);
            return true;
        }
    }
}
